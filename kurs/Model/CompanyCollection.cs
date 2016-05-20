using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace kurs.Model
{
    public static class CompanyCollection
    {
        public static BindingList<Company> CompaniesList = new BindingList<Company>();
        static CompanyCollection()
        {
            CompaniesList = DataBase.GetCollectionFromFile();
        }
        public static void AddCompany(Company comp)
        {
            comp.Id = CompaniesList.LastOrDefault()?.Id + 1 ?? 1;
            CompaniesList.Add(comp);
        }

        public static void DeleteCompany(int id)
        {
            var foundComp = CompaniesList.SingleOrDefault(x => x.Id == id);
            if (foundComp != null) 
                CompaniesList.Remove(foundComp);
            else
                throw new KeyNotFoundException("Ooops... Id was not found!");
        }

        public static void ChangeCompany(int id, Company company)
        {
            var foundComp = CompaniesList.SingleOrDefault(x => id == x.Id);
            if (foundComp != null)
            {
                company.Id = id;
                CompaniesList[(CompaniesList.IndexOf(foundComp))] = company;
            }
            else
                throw new KeyNotFoundException("Ooops... Id was not found!");
        }

        /// <summary>
        /// Поиск компаний в коллекции по заданным параметрам
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static BindingList<Company> Search(Company company)
        {
            var collection = new List<Company>();
            foreach (var z in CompaniesList)
                collection.Add(z);
            if (company.Services.Count() == 1 && company.Services[0] == "")
                company.Services = new string[0];
            if (company.WorkDays.Count() == 1 && company.WorkDays[0] == "")
                company.WorkDays = new string[0];


            collection.RemoveAll(x => !(x.Address.Contains(company.Address) && 
            (company.Kind.ToString() != "empty") ? x.Kind.Equals(company.Kind) : true &&
            x.Name.Contains(company.Name) &&
            (company.Ownership.ToString() != "empty") ? x.Ownership.Equals(company.Ownership) : true &&
            (company.Specialization.ToString() != "empty") ? x.Specialization.Equals(company.Specialization) : true && 
            x.StartWork.TimeOfDay <= company.StartWork.TimeOfDay &&
            x.EndWork.TimeOfDay >= company.EndWork.TimeOfDay &&
            x.PhoneNumber.Contains(company.PhoneNumber) &&
            x.Services.Except(company.Services).Count() == (x.Services.Count() - company.Services.Count()) &&
            x.WorkDays.Except(company.WorkDays).Count() == (x.WorkDays.Count() - company.WorkDays.Count())));

            var qwe = new BindingList<Company>();
            foreach (var z in collection)
                qwe.Add(z);
            return qwe;
        }

        public static Company GetCompanyById(int id)
        {
            return CompaniesList.SingleOrDefault(x => x.Id == id);
        }
    }
}



/*public static void Search(Dictionary<string, string> dict, ref DataGridView dataGV)// Поиск компании в XML-документе по заданным параметрам
{
    List<XElement> elements = doc.Root.Elements("company").ToList();
    foreach(var s in dict)
    {
        if (s.Key == "workDays" || s.Key == "services")
        {
            var strArr = s.Value.ToLower().Trim().Split(' ');
            elements.RemoveAll(x =>
            {
                var arr = x.Element(s.Key).Elements().Select(z => z.Value.ToLower().Trim()).ToArray();
                return strArr.Length != strArr.Intersect(arr).Count();
            });
        }
        else if(s.Key != "workTime")
            elements.RemoveAll(x => !x.Element(s.Key).Value.ToLower().Contains(s.Value));
    }
    if(dict.ContainsKey("workTime"))
        elements.RemoveAll(x =>
        {
            var startWork = toDateTime(x.Element("workTime").Element("startWork").Value);
            var endWork = toDateTime(x.Element("workTime").Element("endWork").Value);
            var timeArray = dict["workTime"].Trim().Split(' ');
            return !(startWork.TimeOfDay <= toDateTime(timeArray[0]).TimeOfDay
            && endWork.TimeOfDay >= toDateTime(timeArray[1]).TimeOfDay);
        });
   fillDGV(ref dataGV, elements);
}

public static void Add(Company company)// Добавление компании в  XML-документ
{
    XElement elem = createCompanyXEl(company);
    elem.FirstAttribute.Value = GetMaxId().ToString();
    doc.Root.Add(elem);
    doc.Save("db.xml");
}

public static void Change(Company company)//Изменение компании в XML-документе
{
    XElement comp = createCompanyXEl(company);
    doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == company.Id.ToString()).ReplaceWith(comp);
    doc.Save("db.xml");
}

public static void Delete(int Id)// Удаление компании в XML-документе по Id
{
    doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == Id.ToString()).Remove();
    doc.Save("db.xml");
}     

public static int GetMaxId()//Получение максимального Id компании из XML-документа
{
    if (doc.Root.FirstNode == null) return 1;
    return Convert.ToInt32(doc.Root.Elements("company").Last().FirstAttribute.Value) + 1;
}

private static XElement createCompanyXEl(Company company)//Запись компании в XML-документ из объекта Company
{
    XElement services = new XElement("services");
    XElement workDays = new XElement("workDays");
    foreach (string S in company.Services)
        services.Add(new XElement("service", S));
    foreach (string WD in company.WorkDays)
        workDays.Add(new XElement("day", WD));

    return new XElement(new XElement("company",
                                    new XAttribute("id", company.Id),
                                    new XElement("name", company.Name),
                                    new XElement("kind", company.Kind),
                                    new XElement("address", company.Address),
                                    new XElement("phoneNumber", company.PhoneNumber),
                                    new XElement("specialization", company.Specialization),
                                    new XElement("ownership", company.Ownership),
                                    new XElement("workTime",
                                        new XElement("startWork", company.StartWork.TimeOfDay.ToString().Substring(0, 5)),
                                        new XElement("endWork", company.EndWork.TimeOfDay.ToString().Substring(0, 5))),
                                    services,
                                    workDays));
}        

private static Company createCompany(XElement xEl)//Создание объекта Company с помощью чтения XML-документа
{
    if (xEl != null)
    {
        string services = "", days = "";
        foreach (XElement element in xEl.Element("services").Elements("service"))
            services += element.Value + " ";
        foreach (XElement element in xEl.Element("workDays").Elements("day"))
            days += element.Value + " ";

        return new Company()
        {
            Id = Convert.ToInt32(xEl.FirstAttribute.Value),
            Name = xEl.Element("name").Value,
            Kind = xEl.Element("kind").Value,
            Address = xEl.Element("address").Value,
            Ownership = xEl.Element("ownership").Value,
            PhoneNumber = xEl.Element("phoneNumber").Value,
            Specialization = xEl.Element("specialization").Value,
            Services = services.Trim().Split(' '),
            WorkDays = days.Trim().Split(' '),
            StartWork = toDateTime(xEl.Element("workTime").Element("startWork").Value),
            EndWork = toDateTime(xEl.Element("workTime").Element("endWork").Value)
        };
    }
    return null;
}

private static DateTime toDateTime(string time)//Перевод строки формата "hh:mm" в формат DateTime
{
    return Convert.ToDateTime("01/01/1800 " + time + ":00.00");
}

public static Company FindById(string ID)//Поиск компании в XML-документе по Id
{
    XElement El = doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == ID);
    return createCompany(El);
}
/// <summary>
/// 1111111111111111111111
/// </summary>
/// <param name="dataGV"></param>
/// <param name="elements"></param>
private static void fillDGV(ref DataGridView dataGV, List<XElement> elements)//Заполнение DataGridView с с помощью чтения XML-документа
{
    dataGV.ColumnCount = 0;
    var col0 = new DataGridViewTextBoxColumn()
    { Name = "id", HeaderText = @"ID" };
    var col1 = new DataGridViewTextBoxColumn()
    { Name = "name", HeaderText = @"Название" };
    var col2 = new DataGridViewTextBoxColumn()
    { Name = "kind", HeaderText = @"Разряд" };
    var col3 = new DataGridViewTextBoxColumn()
    { Name = "special", HeaderText = @"Специализация" };       
    dataGV.Columns.AddRange(col0, col1, col2, col3);
    foreach (XElement el in elements)
    {
        DataGridViewRow row = new DataGridViewRow();
        DataGridViewCell Id = new DataGridViewTextBoxCell()
        { Value = el.FirstAttribute.Value };
        DataGridViewCell Class = new DataGridViewTextBoxCell()
        { Value = el.Element("kind").Value };
        DataGridViewCell Name = new DataGridViewTextBoxCell()
        { Value = el.Element("name").Value};
        DataGridViewCell Special = new DataGridViewTextBoxCell()
        { Value = el.Element("specialization").Value };               
        row.Cells.AddRange(Id, Name, Class, Special);
        dataGV.Rows.Add(row);
    }
}

}
}
*/