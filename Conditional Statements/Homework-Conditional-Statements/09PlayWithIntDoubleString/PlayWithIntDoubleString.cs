using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type\n1 --> int\n2 --> double\n3 --> string");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Please enter a int number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(b + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double number");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine(c + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string");
                string d = Console.ReadLine();
                Console.WriteLine(d + "*");
                break;
            default:
                Console.WriteLine("not a proper choice");
                break;
        }
    }
}

