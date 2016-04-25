using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine(a);
        Console.WriteLine(b);

        int userValue = 8877845;
        double userValue1 = 4554353.354368790;
        Console.Write("type a short number without a comma :");
        userValue = int.Parse(Console.ReadLine());
        Console.Write("write another number - real number:");
        userValue1 = double.Parse(Console.ReadLine());

        Console.WriteLine(@"To your first number I added ""a"" with null value. ");
        Console.WriteLine(userValue + a);
        Console.WriteLine("To your second Pencho added \"b\" with null value.");
        Console.WriteLine(userValue1 + b);


    }
}
       
        
        
  

