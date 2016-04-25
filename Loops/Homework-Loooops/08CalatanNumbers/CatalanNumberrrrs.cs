using System;
using System.Numerics;   //added reference
class CatalanNumberrrrs
{
    static void Main()
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        
        BigInteger part1 = 1;  //2n
        BigInteger part2 = 1;  //n+1
        BigInteger part3=1;    //n
        for (int i = 1; i <= 2*n; i++)
        {
            part1 *= i;
            if (i <= n + 1)
            {
                part2 *= i;
            }
            if (i <= n)
            {
                part3 *= i;
            }
        }
        Console.WriteLine(part1/(part2*part3));
    }
}

