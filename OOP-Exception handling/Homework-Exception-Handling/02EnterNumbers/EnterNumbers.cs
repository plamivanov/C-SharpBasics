using System;


namespace _02EnterNumbers
{
   public class EnterNumbers
    {
        static void Main()
        {
            int [] ten = new int[10];
            int i = 0;
            int t = 0;
            int g = 0;
            
            while (i < 10)
            {
                t = ReadNumber();
                
                if (t< 100 && t > 0 && t>g)
                {
                    g = t;
                    ten[i] = g;
                    i++;
                }
                else if (t<100&&t>0)
                {
                    Console.WriteLine("Should be greater than {0} ;)",g);
                }
            }
            Console.WriteLine("The sequence is");
            foreach (var item in ten)
	            {
		             Console.Write(item+" ");
	            }
        }
            
            public static int ReadNumber()
            {
                int u=0;
                try
                {
                    Console.Write("enter an integer: ");
                    u = int.Parse(Console.ReadLine());
                    if (u < 1 || u > 100)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    
                }
                catch(IndexOutOfRangeException)
                {
                        Console.WriteLine("The number should be between 1 and 100...");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number...");
                }
                
                return u;
                
            }
    }
}
 

