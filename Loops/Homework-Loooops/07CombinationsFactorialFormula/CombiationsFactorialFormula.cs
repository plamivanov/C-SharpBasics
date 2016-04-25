using System;
using System.Numerics;
class CombiationsFactorialFormula
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int sum = n - k;
        BigInteger nsum = 1;
        BigInteger ksum = 1;
        BigInteger fsum = 1;
        for (int i = 1; i <= n; i++)
        {
            nsum *= i;
        }
        for (int i = 1; i <= k; i++)
		{
            ksum *= i;
		}
        for (int i = 1; i <= sum; i++)
		{
            fsum *= i;
		}
        Console.WriteLine(nsum/(ksum*fsum));

    }
}

