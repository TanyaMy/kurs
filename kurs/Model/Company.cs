using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Model
{
    //перечисления 

    //Разряд
    public enum Kind
    {
        любой,
        коммунальное,
        промышленное,
        производственное,
        коммерческое       
    }

    //Специализация
    public enum Specialization
    {
        любая,
        отопление,
        вода,
        канализация,
        строительство,
        электроэнергия,
        ремонт,
        связь,
        другое       
    }

    //Собственность
    public enum Ownership
    {
        любая,
        частная,
        государственная,
        муниципальная       
    }

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Kind Kind { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Specialization Specialization { get; set; }
        public string[] Services { get; set; }        
        public Ownership Ownership { get; set; }

        //Рабочии дни компании
        public string[] WorkDays { get; set; }

        //Время начала рабочего дня
        public DateTime StartWork { get; set; }

        //Время окончания рабочего дня
        public DateTime EndWork { get; set; }
        
    }
}
