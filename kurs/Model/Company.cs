using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public string[] Services { get; set; }
        public string Ownership { get; set; }
        public string[] WorkDays { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }


        public override string ToString()
        {
            return "Name: " + Name;
        }
    }
}
