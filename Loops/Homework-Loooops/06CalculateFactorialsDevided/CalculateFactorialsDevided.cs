using System;
using System.Numerics;
class CalculateFactorialsDevided
{
    static void Main()
    {
        Console.WriteLine("she delim faktoriali, izberi si chsla n i k");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger sum = 1;
        BigInteger ksum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
        }
        for (int i = 1; i <= k; i++)
        {

            ksum *= i;
        }
        Console.WriteLine(sum / ksum);
        
    }
}

