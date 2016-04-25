using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigitNumber
{
    class FourDigNum
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd / 10) % 10;
            int d = abcd % 10;

            Console.WriteLine("{0}+{1}+{2}+{3}={4}",a,b,c,d,a+b+c+d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, b, c, a);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
            
        }
    }
}
