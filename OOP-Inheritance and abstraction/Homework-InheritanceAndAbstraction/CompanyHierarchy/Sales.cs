using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy
{
    public class Sales:ISales
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName,DateTime date,decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
