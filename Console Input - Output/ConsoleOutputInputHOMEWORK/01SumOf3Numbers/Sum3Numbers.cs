using System;

class Sum3Numbers
{
    static void Main()
    {
        
        Console.WriteLine("Write down 3 real numbers and find out their sum :) :");
        Console.Write("1st real number (a): ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("2nd real number (b): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("3rd real number (c): ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of your numbers is:");
        
        Console.WriteLine("a + b + c = {0}",a+b+c);
    }
}

