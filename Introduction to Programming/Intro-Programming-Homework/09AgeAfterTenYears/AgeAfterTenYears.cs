using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("What is your date of birth? Write it down and press ENTER...");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = (int)((now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine();
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine();
        Console.WriteLine("And after 10 years you will be " + (age + 10) + " years old");
        Console.WriteLine();
    }

}

