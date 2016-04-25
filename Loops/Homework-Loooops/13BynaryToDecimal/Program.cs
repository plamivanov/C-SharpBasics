using System;

class Program
{
    static void Main()
    {
        string ary = Console.ReadLine();
        char[] bynary = ary.ToCharArray();
        int g = bynary.Length;
        long dec = 0;


        for (int i = 0; i < g; i++)
        {

            if (bynary[i] == '1')
            {
                dec += (long)Math.Pow(2, (g - i - 1));
            }

        }
        Console.WriteLine(dec);
    }
}