using System;


class Matrica
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int factN = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j=i; j <n+i; j++)
            {
                factN = j;
                
                Console.Write("{0:00.}  ",factN); 
            }
            
            Console.WriteLine();
        }
    }
}

