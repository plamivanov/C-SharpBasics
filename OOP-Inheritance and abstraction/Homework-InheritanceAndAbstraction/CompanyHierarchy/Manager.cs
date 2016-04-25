using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;
namespace CompanyHierarchy
{
   public class Manager:Employee,IManager
    {
        private List<Employee> employeesUnderCommand;
        public Manager(string id,string firstName,string lastName,decimal salary,Departments department,List<Employee>employeesUnderCommand)
            :base(id,firstName,lastName,salary,department)
        {
            this.EmployeesUnderCommand = employeesUnderCommand;
        }
        public List<Employee> EmployeesUnderCommand { get; set; }

       public override string ToString()
        {
           string b="";
           foreach (var item in this.EmployeesUnderCommand)
            {
	            b+=item.FirstName+" "+item.LastName+" "+item.Salary+" "+item.Department+"\n";
            }
            return base.ToString()+"\nEmplyees under command: \n"+b;
        }
    }
}
