using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 10; i++)
        {
            if(i%2==0)
            {
                Console.Write(i + ",-");
            }
            else
            {
                Console.Write(i + ",");
            }

        }
        Console.Write(11);
        Console.WriteLine();
    }
}  


