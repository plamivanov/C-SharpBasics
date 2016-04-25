using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
    public class IndividualCustomer:Customers
    {
        private int age;
        public IndividualCustomer(string name,int number,int age)
            :base(name,number)
        {
            this.Age = age;
        }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format(base.Name+" "+base.Number+" "+this.Age);
        }
    }
}
