using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Computer
    {
        private string name;
        private List<Component> components;
        private decimal? price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Put valid name...");
                }
                this.name = value;
            }
        }
        public decimal? Price { get; set; }

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.components = components;
            this.Price = calculatePrice(this.components);
        }

        private decimal? calculatePrice(List<Component> comps)
        {
            decimal? totalPrice = 0m;
            foreach (Component comp in comps)
            {
                totalPrice += comp.Price;
            }

            return totalPrice;
        }

        public void PrintConfiguration()
        {
            string configuration = "PC name: " + this.Name + "\n";
            foreach (Component component in this.components)
            {
                configuration += component.ToString() + "\n";
            }
            configuration += "Total Price: " + this.Price+ " BGN";
            Console.WriteLine(configuration);
        }
    }  //не съм защитил неправилна употреба кой знае колко.....поглеждал съм и от готови неща,кво да се прай
}
