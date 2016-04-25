using System;

class StringObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = a + " " + b;
        string d = (string)c;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}",a,b,c,d);
    }
}

