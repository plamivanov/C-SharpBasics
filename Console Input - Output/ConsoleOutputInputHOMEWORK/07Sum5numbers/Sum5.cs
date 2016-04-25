using System;

class Sum5
{
    static void Main()
    {
        //Tova se pravi s masivi, ma ne gi znam oshte :)
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
            
        Console.WriteLine("{0} {1} {2} {3} {4} = {5}", a, b, c, d, e, a+b+c+d+e);
    }
}

