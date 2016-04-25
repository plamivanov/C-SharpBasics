using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] poredica=new int[n];
            int b;
            for (int i = 0; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                poredica[i]=b;
                
            }
            Array.Sort(poredica);
            foreach (var item in poredica)
            {
                Console.WriteLine(item);
            }
        }
    }
}
