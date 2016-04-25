using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //не съм разчиствал :)

namespace Catalog              
{
    class Catalog
    {
        static void Main(string[] args)
        {
            Component processor = new Component("Intel Core", "2.5 GHz", 150.00m);
            Component processor1 = new Component("Intel Pentium", "2.16 GHz", 100.00m);
            Component battery = new Component("Alkalna", "6-cells", 50.50m);
            Component battery1 = new Component("Li-edikakvosi", "4-cells", 40.50m);
            Component monitor = new Component("Panasonic", "15 inch", 100.00m);
            Component monitor1 = new Component("Compaq", "17 inch", 89.00m);
            Component ram = new Component("Ram Pamet", "8GB", 80.00m);
            Component ram1 = new Component("Ram Pamet2", "4GB", 60.00m);

            List<Component> components1 = new List<Component>()
            {
                processor, battery, monitor, ram
            };

            List<Component> components2 = new List<Component>()
            {
                 processor1,monitor1,ram
            };

            List<Component> components3 = new List<Component>()
            {
                 monitor, ram1,battery1
            };
           
            Computer lenovo = new Computer("Lenovo", components1);
            Computer hp = new Computer("HP", components2);
            Computer asus = new Computer("ASUS", components3);

            List<Computer> computers = new List<Computer>()
            {
                lenovo, hp, asus
            };

            List<Computer> sortedComputers = computers.OrderBy(computer => computer.Price).ToList();// c# advanced не съм минавал...директно на ооп

            foreach (Computer item in sortedComputers)
            {
                item.PrintConfiguration();
                Console.WriteLine();
            }

        }
    }
}
