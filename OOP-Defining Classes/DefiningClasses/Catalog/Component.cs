using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name,string details,decimal price)
        {
            this.Name = name;
            this.Details=details;
            this.Price=price;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("enter valid name");
                }
                this.name = value; }
        }
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return this.Name + ", " + (this.Details != null ? this.Details + ", " : "") + this.Price + " BGN";
        }
    }
}
