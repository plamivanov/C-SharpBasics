using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] redica=Console.ReadLine().Split(' ');
           int g = redica.Length;
           int prnechetni = 1;
           int prchetni = 1;
            for (int i = 0; i < g; i++)
           {
               int b = int.Parse(redica[i]);
               if (i % 2 ==1)
               {
                   prnechetni *= b;
               }
               else if (i%2==0)
               {
                   prchetni *= b;
               }
           }

            if (prnechetni == prchetni)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",prnechetni);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", prnechetni);
                Console.WriteLine("even_product = {0}",prchetni);
            }  
              
            
            
            

        }
    }
}
