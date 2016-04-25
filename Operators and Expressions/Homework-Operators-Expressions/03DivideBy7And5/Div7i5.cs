using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DivideBy7And5
{
    class Div7i5
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool d = a % 7 == 0 && a % 5 == 0;
            if(a==0)
                Console.WriteLine(false);
            else
            Console.WriteLine(d);
        }
    }
}
