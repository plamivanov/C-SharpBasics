using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
   public class CompanyCustomer:Customers
    {
       private string uniqueNumber;

       public CompanyCustomer(string name,int number,string uniqueNiumber)
           :base(name,number)
       {
           this.UniqueNumber = uniqueNiumber;
       }
       public string UniqueNumber { get; set; }

       public override string ToString()
       {
           return string.Format(base.Name + " " + base.Number + " " + this.UniqueNumber);
       }

    }
}
