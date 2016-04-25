using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool inside = ((x-0)*(x-0)) + ((y-0)*(y-0)) <= 2 * 2;
            Console.WriteLine(inside);
        }
    }
}
