using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfBokoTikvanov
{
    public class Customers
    {
        private string name;
        private int number;
        public Customers(string name,int number)
        {
            this.Name = name;
            this.Number = number;
        }
        public string  Name { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return string.Format(this.Name + " " + this.Number);
        }

    }
}
