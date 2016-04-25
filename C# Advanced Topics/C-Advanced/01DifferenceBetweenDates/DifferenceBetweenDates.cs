using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Parse(Console.ReadLine());
            DateTime then = DateTime.Parse(Console.ReadLine());

            Console.WriteLine((then-now).TotalDays);
        }
    }
}
