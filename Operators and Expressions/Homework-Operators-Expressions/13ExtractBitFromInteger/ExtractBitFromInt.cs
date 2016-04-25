using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ExtractBitFromInteger
{
    class ExtractBitFromInt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int m = n >> p;
            if (m%2==0)
                Console.WriteLine(0);
            else
                Console.WriteLine(1);

        }
    }
}
