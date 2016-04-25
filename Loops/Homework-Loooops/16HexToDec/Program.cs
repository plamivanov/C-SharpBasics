using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            char[] otdelni = hex.ToCharArray();
            char nqkvo;
            long g = otdelni.Length;
            int q=0;
            long result = 0;
            for (int i = 1; i <= g; i++)
            {
                nqkvo = otdelni[i-1];
                switch (nqkvo)
                {
                    case '0': q = 0;
                        break;
                    case '1': q = 1;
                        break;
                    case '2': q = 2;
                        break;
                    case '3': q = 3;
                        break;
                    case '4': q = 4;
                        break;
                    case '5': q = 5;
                        break;
                    case '6': q = 6;
                        break;
                    case '7': q = 7;
                        break;
                    case '8': q = 8;
                        break;
                    case '9': q = 9;
                        break;
                    case 'A': q = 10;
                            break;
                    case 'B': q = 11;
                            break;
                    case 'C': q = 12;
                            break;
                    case 'D': q = 13;
                            break;
                    case 'E': q = 14;
                            break;
                    case 'F': q = 15;
                            break;

                }
                result += (long)(Math.Pow(16, g-i)*q);
            }
            Console.WriteLine(result);
        }
    }
}
