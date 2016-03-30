using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    class CompanyCollection
    {
        public List<Company> companies;         

        public CompanyCollection()
        {
            companies = new List<Company>();
        }

        public void Add(Company a)
        {
            companies.Add(a);
        }

        public void Delete(Company a)
        {
            companies.Remove(a);
        }

        
        public void Change(Company a)
        {
            companies.Add(a);
        }
    }
}
