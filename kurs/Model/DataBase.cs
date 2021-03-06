﻿using System;
using System.Xml.Linq;
using System.ComponentModel;

namespace kurs.Model
{
    /// <summary>
    /// Для работы с XML-документом: запись/удаление/изменение/чтение 
    /// (поиск по различным параметрам, формирование объекта Company).
    /// </summary>
    static class DataBase
    {
        //Объявление Xml-документа.
        private static XDocument doc;

        //Путь к Xml-документу.
        private static string _filePath = @"db.xml";

        //Корневой элемент Xml-документа.
        private static XElement Root;

        /// <summary>
        /// Статический конструктор без параметров.
        /// Создание или подключение документа.
        /// </summary>
        static DataBase()// 
        {
            if (System.IO.File.Exists(_filePath))
                doc = XDocument.Load(_filePath);
            else {
                doc = new XDocument(new XElement("companies"));
                doc.Save("db.xml");
            }
            Root = doc.Element("companies");
        }

        /// <summary>
        /// Метод сохранения коллекции компаний в файл.
        /// </summary>
        public static void SaveToFile(BindingList<Company> list)
        {
            Root.RemoveAll();
            foreach (var el in list)
            {
                Root.Add(getXElementFromCompany(el));
            }
            doc.Save(_filePath);
        }

        /// <summary>
        ///  Метод создания коллекции компаний
        ///  с помощью чтения из файла.
        /// </summary>
        /// <returns>Возвращает список компаний.</returns>
        public static BindingList<Company> GetCollectionFromFile()
        {
            var list = new BindingList<Company>();

            foreach (var elem in Root.Elements())
            {
                var tmp = getCompanyFromXElement(elem);
                if(tmp != null)
                    list.Add(tmp);
            }
            return list;
        }

        //Создание Xml-элемента <company> из объекта Company
        private static XElement getXElementFromCompany(Company company)
        {
            XElement services = new XElement("services");
            XElement workDays = new XElement("workDays");
            foreach (string S in company.Services)
                services.Add(new XElement("service", S));
            foreach (string WD in company.WorkDays)
                workDays.Add(new XElement("day", WD));

            return new XElement
                (new XElement("company",
                     new XAttribute("id", company.Id),
                     new XElement("name", company.Name),
                     new XElement("kind", company.Kind),
                     new XElement("address", company.Address),
                     new XElement("phoneNumber", company.PhoneNumber),
                     new XElement("specialization", company.Specialization),
                     new XElement("ownership", company.Ownership),
                     new XElement("workTime",
                         new XElement("startWork",
                            company.StartWork.TimeOfDay.ToString().Substring(0, 5)),
                         new XElement("endWork",
                             company.EndWork.TimeOfDay.ToString().Substring(0, 5))),
                     services,
                     workDays));
        }

        //Создание объекта Company из Xml-элемента <company>
        //с помощью чтения из файла.
        private static Company getCompanyFromXElement(XElement xCompany)
        {
            if (xCompany != null)
            {
                string services = "", days = "";
                foreach (XElement element in xCompany.Element("services")?
                        .Elements("service"))
                    services += element.Value + " ";
                foreach (XElement element in xCompany.Element("workDays")?
                        .Elements("day"))
                    days += element.Value + " ";
                var company = new Company(){
                    Id = Convert.ToInt32(xCompany.FirstAttribute?.Value ?? "-1"),
                    Name = xCompany.Element("name")?.Value ?? "emptyName",
                    Kind = (Kind)Enum.Parse(typeof(Kind), xCompany.Element("kind")?
                        .Value ?? "любой", true),
                    Address = xCompany.Element("address")?.Value ?? "empty",
                    Ownership = (Ownership)Enum.Parse(typeof(Ownership),
                        xCompany.Element("ownership")?.Value ?? "любая", true),
                    PhoneNumber = xCompany.Element("phoneNumber")?.Value ?? "empty",
                    Specialization = (Specialization)Enum.Parse(typeof(Specialization),
                        xCompany.Element("specialization")?.Value ?? "любая", true),
                    Services = services.Trim().Split(' '),
                    WorkDays = days.Trim().Split(' '),
                    StartWork = ToDateTime(xCompany.Element("workTime")
                        .Element("startWork")?.Value ?? "00:00"),
                    EndWork = ToDateTime(xCompany.Element("workTime")
                        .Element("endWork")?.Value ?? "23:59")
                };
                return company;
            }
            return null;
        }
       
        // Метод перевода строки формата "hh:mm" в формат DateTime      
        public static DateTime ToDateTime(string time)
        {
            return Convert.ToDateTime("01/01/1800 " + time + ":00.00");
        }       
    }
}