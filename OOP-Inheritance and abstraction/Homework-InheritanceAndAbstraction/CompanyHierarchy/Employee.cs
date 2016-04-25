using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
   public class Employee:Person,IEmployee
    {
       private decimal salary;
       private Departments department;

          public Employee (string id,string firstName,string lastName,decimal salary,Departments department)
              :base(id,firstName,lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
          public decimal Salary { get; set; }
          public Departments Department { get; set; }

          public override string ToString()
          {
              return base.ToString()+" "+this.Salary+" "+this.Department;
          }
      
    }
}
