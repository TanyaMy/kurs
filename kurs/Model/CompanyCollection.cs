using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace kurs.Model
{
    /// <summary>
    /// Данный класс содержит коллекцию объектов Company и методы для работы с
    /// этой коллекцией, такие как удаление, добавление, изменение, поиск
    /// компании по заданным параметрам.
    /// </summary>

    public static class CompanyCollection
    {
        //Список компаний, поддерживающий привязку данных.
        public static BindingList<Company> CompaniesList 
            = new BindingList<Company>();

        //Конструктор без параметров.
        static CompanyCollection()
        {
            CompaniesList = DataBase.GetCollectionFromFile();
        }

        //Добавление компании в список.
        public static void AddCompany(Company comp)
        {
            comp.Id = CompaniesList.LastOrDefault()?.Id + 1 ?? 1;
            CompaniesList.Add(comp);
        }

        //Удаление компании по Id. 
        public static void DeleteCompany(int id)
        {
            var foundComp = CompaniesList.SingleOrDefault(x => x.Id == id);
            if (foundComp != null) 
                CompaniesList.Remove(foundComp);
            else
                throw new KeyNotFoundException("Ooops... Id was not found!");
        }

        //Замена компании с указанным Id друой компанией.
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
        /// Поиск компаний в коллекции по заданным параметрам. Создание копии
        /// списка компаний и удаление из него компаний, не удовлетворяющих заданным
        /// критериям поиска с помощью лямбда-выражения.
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
            ((company.Kind.ToString() != "любой") ? 
                x.Kind.Equals(company.Kind) : true) &&            
            ((company.Ownership.ToString() != "любая") ? 
                x.Ownership.Equals(company.Ownership) : true) &&
            ((company.Specialization.ToString() != "любая") ? 
                x.Specialization.Equals(company.Specialization) : true) &&
            ((company.StartWork.ToString().Substring(11, 4) == "0:00" &&
                company.EndWork.ToString().Substring(11, 5) == "23:59") ? 
                    true : (x.StartWork.TimeOfDay <= company.StartWork.TimeOfDay)) &&
            ((company.StartWork.ToString().Substring(11, 4) == "0:00" && 
                company.EndWork.ToString().Substring(11, 5) == "23:59") ? 
                    true : (x.EndWork.TimeOfDay >= company.EndWork.TimeOfDay)) &&
            x.PhoneNumber.Contains(company.PhoneNumber) &&
            x.Name.Contains(company.Name) &&
            x.Address.Contains(company.Address) &&
            x.Services.Except(company.Services).Count() ==
                (x.Services.Count() - company.Services.Count()) &&
            x.WorkDays.Except(company.WorkDays).Count() == 
                (x.WorkDays.Count() - company.WorkDays.Count())));         

            var res = new BindingList<Company>();
            foreach (var z in collection)
                res.Add(z);
            return res;
        }

        //получение объекта Company по указанному Id.
        public static Company GetCompanyById(int id)
        {
            return CompaniesList.SingleOrDefault(x => x.Id == id);
        }
    }
}