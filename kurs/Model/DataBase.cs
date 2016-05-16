using System;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace kurs.Model
{
    static class DataBase// Для работы с XML-документом: зпись (удаление, изменение), 
                         //чтение(поиск по различным параметрам, формирование объекта Company).
    {
        static XDocument doc;
        static DataBase()// Конструктор без параметров. Создание или загрузка документа.
        {
            if (System.IO.File.Exists("db.xml"))
                doc = XDocument.Load("db.xml");
            else {
                doc = new XDocument(new XElement("companies"));
                doc.Save("db.xml");
            }
        }

        public static void Search(IDictionary<string, string> dict, ref DataGridView dataGV)// Поиск компании в XML-документе по заданным параметрам
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
                    var startWork = ToDateTime(x.Element("workTime").Element("startWork").Value);
                    var endWork = ToDateTime(x.Element("workTime").Element("endWork").Value);
                    var timeArray = dict["workTime"].Trim().Split(' ');
                    return !(startWork.TimeOfDay <= ToDateTime(timeArray[0]).TimeOfDay
                    && endWork.TimeOfDay >= ToDateTime(timeArray[1]).TimeOfDay);
                });
           FillDGV(ref dataGV, elements);
        }

        public static void Add(Company company)// Добавление компании в  XML-документ
        {
            XElement elem = CreateCompanyXEl(company);
            elem.FirstAttribute.Value = GetMaxId().ToString();
            doc.Root.Add(elem);
            doc.Save("db.xml");
        }

        public static void Change(Company company)//Изменение компании в XML-документе
        {
            XElement comp = CreateCompanyXEl(company);
            doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == company.Id.ToString()).ReplaceWith(comp);
            doc.Save("db.xml");
        }

        public static void Delete(int Id)// Удаление компании в XML-документе по Id
        {
            doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == Id.ToString()).Remove();
            doc.Save("db.xml");
        }
      
        public static void Read(ref DataGridView dataGV)// Вывод всех компаний из XML-документа
        {
            FillDGV(ref dataGV, doc.Root.Elements().ToList());
        }

        public static int GetMaxId()//Получение максимального Id компании из XML-документа
        {
            if (doc.Root.FirstNode == null)
                return 0;
            return Convert.ToInt32(doc.Root.Elements("company").Last().FirstAttribute.Value) + 1;
        }

        private static XElement CreateCompanyXEl(Company company)//Запись компании в XML-документ из объекта Company
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
                                            new XElement("class", company.Class),
                                            new XElement("address", company.Address),
                                            new XElement("phoneNumber", company.PhoneNumber),
                                            new XElement("specialization", company.Specialization),
                                            new XElement("ownership", company.Ownership),
                                            new XElement("workTime",
                                                new XElement("startWork", company.StartWork.Hour + ":" + company.StartWork.Minute),
                                                new XElement("endWork", company.EndWork.Hour + ":" + company.EndWork.Minute)),
                                            services,
                                            workDays));
        }

        private static Company CreateCompany(XElement xEl)//Создание объекта Company с помощью чтения XML-документа
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
                    Class = xEl.Element("class").Value,
                    Address = xEl.Element("address").Value,
                    Ownership = xEl.Element("ownership").Value,
                    PhoneNumber = xEl.Element("phoneNumber").Value,
                    Specialization = xEl.Element("specialization").Value,
                    Services = services.Trim().Split(' '),
                    WorkDays = days.Trim().Split(' '),
                    StartWork = ToDateTime(xEl.Element("workTime").Element("startWork").Value),
                    EndWork = ToDateTime(xEl.Element("workTime").Element("endWork").Value)
                };
            }
            return null;
        }
        
        private static DateTime ToDateTime(string time)//Перевод строки в формат DateTime
        {
            return Convert.ToDateTime("01/01/1800 " + time + ":00.00");
        }

        public static Company FindById(string ID)//Поиск компании в XML-документе по Id
        {

            XElement El = doc.Root.Elements("company").Single(x => x.FirstAttribute.Value == ID);
            return CreateCompany(El);
        }

        private static void FillDGV(ref DataGridView dataGV, List<XElement> elements)//Заполнение DataGridView с с помощью чтения XML-документа
        {
            dataGV.ColumnCount = 0;
            var col0 = new DataGridViewTextBoxColumn() { Name = "id", HeaderText = @"ID" };
            var col1 = new DataGridViewTextBoxColumn() { Name = "name", HeaderText = @"Название" };
            var col2 = new DataGridViewTextBoxColumn() { Name = "class", HeaderText = @"Разряд" };
            var col3 = new DataGridViewTextBoxColumn() { Name = "special", HeaderText = @"Специализация" };           
            dataGV.Columns.AddRange(col0, col1, col2, col3);

            foreach (XElement el in elements)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell Id = new DataGridViewTextBoxCell();
                DataGridViewCell Class = new DataGridViewTextBoxCell();
                DataGridViewCell Name = new DataGridViewTextBoxCell();
                DataGridViewCell Special = new DataGridViewTextBoxCell();
                Id.Value = el.FirstAttribute.Value;
                Class.Value = el.Element("class").Value;
                Special.Value = el.Element("specialization").Value;
                Name.Value = el.Element("name").Value;
                row.Cells.AddRange(Id, Name, Class, Special);
                dataGV.Rows.Add(row);
            }
        }
       
    }
}