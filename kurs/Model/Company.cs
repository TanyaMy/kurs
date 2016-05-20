using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Model
{
    public enum Kind
    {
        коммунальное,
        промышленное,
        производственное,
        коммерческое, 
        empty
    }
    public enum Specialization
    {
        отопление,
        вода,
        канализация,
        строительство,
        электроэнергия,
        ремонт,
        связь,
        другое,
        empty
    }
    public enum Ownership
    {
        частная,
        государственная,
        муниципальная,
        empty
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
        public string[] WorkDays { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        
    }
}
