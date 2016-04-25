using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());


        double bigestNum = a;
        if (b >= bigestNum)
        {
            bigestNum = b;
        }
        if (c >= bigestNum)
        {
            bigestNum = c;
        }
        if (d >= bigestNum)
        {
            bigestNum = d;
        } 
        if (e >= bigestNum)
        {
            bigestNum = e;
        }
        Console.WriteLine(bigestNum);

    }
}

