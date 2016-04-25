using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;

namespace CompanyHierarchy
{
    public class RegularEmployee:Employee

    {
         public RegularEmployee (string id,string firstName,string lastName,decimal salary,Departments department)
              :base(id,firstName,lastName,salary,department)
        {

        }
         public override string ToString()
         {
             return base.ToString();
         }

    }
}
