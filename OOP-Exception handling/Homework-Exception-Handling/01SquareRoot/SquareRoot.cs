using System;

namespace _01SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("write a number:");
            string a = Console.ReadLine();

            try
            {
                int b = int.Parse(a);
                if (b < 0)
                {
                    throw new IndexOutOfRangeException();
                }
               
                Console.WriteLine(Math.Sqrt(b));
            }
            catch (FormatException)
            {
                Console.WriteLine("You should enter ONE positive integer with max value of {0}",int.MaxValue);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number should be in range {0}..{1}",0,int.MaxValue);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you've entered is too long.");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
