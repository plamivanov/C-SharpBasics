using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12BitN3
{
    class BitN3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int newN = n >> 3;
            if (newN%2==0)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);

            
        }
    }
}
