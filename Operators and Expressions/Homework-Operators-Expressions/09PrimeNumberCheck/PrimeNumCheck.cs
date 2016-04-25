using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PrimeNumberCheck
{
    class PrimeNumCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer form 1 to 100: ");
            int isPrime = int.Parse(Console.ReadLine());
            bool pr = true;
            
            for (int i = 2; i < isPrime; i++)
            {
                if (isPrime % i != 0)
                {
                    Console.WriteLine(pr);
                    break;
                }
                
                else 
                {
                    Console.WriteLine(false);
                    break;
                }
            
             }
           
        }
    }
}
