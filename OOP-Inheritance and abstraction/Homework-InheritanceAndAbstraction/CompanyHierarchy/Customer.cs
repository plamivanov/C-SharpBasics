using System;
using System.Collections.Generic;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    class Customer:Person,ICustomer
    {
        private decimal netPerchaseAmount;

        public Customer(string id,string firstName,string lastName,decimal netPerchaseAmount)
            :base(id,firstName,lastName)
        {
            this.NetPerchaseAmount = netPerchaseAmount;
        }
        public decimal NetPerchaseAmount { get; set; }

        public override string ToString()
        {
            return base.ToString()+" "+this.NetPerchaseAmount;
        }
    }
}
