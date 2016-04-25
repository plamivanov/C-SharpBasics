using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop asusX55A = new Laptop("AsusX55A",700.89m); //mandatory model and price
            //add examples
            //asusX55A.BatteryLife = 4.54; 
            //asusX55A.GraphicsCard="snjnja.san 45";

            Laptop hp1 = new Laptop("HP-g68", "HP", "Intel Core", 4, "Intel Pentium", "1TB","17 inch", new Battery("Nekva", 4, 1000), 4.5, 878.78m);

            Laptop pravec1 = new Laptop("Pravec2018", 10000.00m);
            pravec1.Processor = "Intel Core i-10";
            pravec1.Screen = "15.7 inch";
            pravec1.Ram = 12;

            Laptop exeption = new Laptop("Nqkyv", 629.00m);
            exeption.Ram = -5;                      //няма да се включи.....не съм ги защитил кой знае колко може още много да се прави...

            Console.WriteLine(asusX55A);
            Console.WriteLine(hp1);
            Console.WriteLine(pravec1);
            Console.WriteLine(exeption);
        }
    }
}
