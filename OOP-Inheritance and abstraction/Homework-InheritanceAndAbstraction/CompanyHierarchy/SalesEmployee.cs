using System;
using System.Collections.Generic;
using System.Linq;
using CompanyHierarchy.Einumerable;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    class SalesEmployee:RegularEmployee,ISalesEmployee
    {
        private List<Sales> sales;
        
        public SalesEmployee(string id,string firstName,string lastName,decimal salary,Departments department,List<Sales>sales)
            :base(id,firstName,lastName,salary,department)
        {
            this.Sales = sales;
        }
        public List<Sales> Sales { get; set; }

        public override string ToString()
        {   
            string e="";
            foreach (var item in this.Sales)
	        {
                e+=item.ProductName+" "+item.Date.ToString("dd-MM-yyyy")+" "+item.Price+"lv.\n";
 	        }
            return base.ToString()+"\n"+e;
        }
    }
}
