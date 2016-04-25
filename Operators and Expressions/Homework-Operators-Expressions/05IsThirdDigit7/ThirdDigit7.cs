using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05IsThirdDigit7
{
    class ThirdDigit7
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool isSeven = (a / 100) % 10 == 7;
            Console.WriteLine(isSeven);
        }
    }
}
