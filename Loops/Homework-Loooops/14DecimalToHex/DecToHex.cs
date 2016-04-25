using System;

class DecToHex
{
    static void Main()
    {
        long g = long.Parse(Console.ReadLine());
        string[] poredica = {"0","1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
        string hex="";
        if (g == 0)
            Console.WriteLine(0);
        while (g >0)
        {
            long b = g % 16;
            g /= 16;

            hex += poredica[b];

        }
        char[] charArray = hex.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}

