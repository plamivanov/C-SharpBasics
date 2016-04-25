using System;

class Persons
{
    static void Main()
    {
        Person a = new Person("Bart",4);     // only name and age
        Console.WriteLine(a);

        Person b = new Person("Jiro", 45, "aidebe@burgas.bg"); //  @
        Console.WriteLine(b);

        Person c = new Person("Ebe Sand", 55, "ebesand@areve.com"); // everything
        Console.WriteLine(c);
    }
}

