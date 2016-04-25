using System;

class NumberAsWords1000
{
    static void Main()
    {    
        int number = int.Parse(Console.ReadLine());
        int number1 = number % 100;
        int number2 = number1 / 10;

        string[] ot0do19 = new string[20] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", 
                "Seventeen", "Eighteen", "Nineteen"};
        string[] desetici = new string[10] { "Ten", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        if (number > -1 && number < 20)
        {
            Console.WriteLine(ot0do19[number]);
        }
        else if (number > 19 && number % 10 == 0 && number < 100)
        {
            Console.WriteLine(desetici[number / 10]);
        }
        else if (number > 19 && number < 100)
        {
            Console.WriteLine(desetici[number / 10] + " " + ot0do19[number % 10].ToLower());
        }
        else if (number > 99 && number % 100 == 0)
        {
            Console.WriteLine(ot0do19[number / 100] + " hundred");
        }
        else if (number % 100 < 20)
        {
            Console.WriteLine(ot0do19[number / 100] + " hundred and " + ot0do19[number1].ToLower());
        }
        else if (number > 100 && number < 999 && number % 100 > 19)
        {
            Console.WriteLine(ot0do19[number / 100] + " hundred " + desetici[number2].ToLower() + " " + ot0do19[number / 100].ToLower());
        }
    }
}

