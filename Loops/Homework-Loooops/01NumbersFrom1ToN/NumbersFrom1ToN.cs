using System;
//Не съм писал описания,какво да се въведе...
class NumbersFrom1ToN
{
    static void Main()
    {
        int a =int.Parse(Console.ReadLine());

        for (int i = 1; i < a; i++)
        {
            Console.Write("{0} ",i);
        }
    }
}

