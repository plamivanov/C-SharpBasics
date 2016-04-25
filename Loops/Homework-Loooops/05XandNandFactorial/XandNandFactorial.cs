using System;

class XandNandFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double dum=1;
        double xnastepen=1;
        double fact = 1;
        for (double i = 1; i <= n; i++)
        {
            xnastepen = Math.Pow(x, i);
            fact*=i;
            
            dum += fact / xnastepen;
        }
        Console.WriteLine("{0:0.00000}", dum);
    }
}


            
            
    