using System;

class EqQuadr
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sqrPart = Math.Sqrt(b * b - 4 * a * c);

        if (sqrPart > 0)
        {
            double x1 = (-b - sqrPart) / (2 * a);
            double x2 = (-b + sqrPart) / (2 * a);
            Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
        }



        else if (sqrPart == 0)
        {
            double x1 = (-b - sqrPart) / (2 * a);
            double x2 = (-b + sqrPart) / (2 * a);
            Console.WriteLine("x1=x2={0}", x1);

        }
        else
        {

            Console.WriteLine("No roots");
        }
    }
}

