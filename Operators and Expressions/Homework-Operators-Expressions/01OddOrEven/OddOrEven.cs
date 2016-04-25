using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            bool isEven = a % 2 == 0;
            Console.WriteLine("Even? \n{0}",isEven);
        }
    }
}
