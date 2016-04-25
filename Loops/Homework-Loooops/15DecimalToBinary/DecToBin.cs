using System;

class DecToBin
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string binary = "";

        if (number == 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            while (number > 0)
            {
                int Oor1 = (int)number & 1;
                number >>= 1;
                binary = Oor1.ToString() + binary;
            }
            Console.WriteLine(binary);
        }
    }
}
