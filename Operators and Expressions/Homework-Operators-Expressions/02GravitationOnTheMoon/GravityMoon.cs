using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GravitationOnTheMoon
{
    class GravityMoon
    {
        static void Main(string[] args)
        {
            double manKg = double.Parse(Console.ReadLine());
            double moon = manKg * (17 / 100.00);
            Console.WriteLine(moon);
        }
    }
}
