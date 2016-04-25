using System;

class ExchVarValues
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        int c = a;

        a = b;
        b = c;

        Console.WriteLine(a+"\n"+b);

    }
}

