using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Rectangles
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double per = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("{0} and {1}", per, area);
        }
    }
}
