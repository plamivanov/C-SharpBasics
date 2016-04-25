using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double bigestNum = a;
        if (b >= bigestNum)
        {
            bigestNum = b;
        }
        if (c >= bigestNum)
        {
            bigestNum = c;
        }

        Console.WriteLine(bigestNum);
    }
}
        
  

