using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Write down 2 different numbers (a) and (b):):");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("From both numbers the following is greater :) -->  {0}",Math.Max (a,b));
    
    }
}

