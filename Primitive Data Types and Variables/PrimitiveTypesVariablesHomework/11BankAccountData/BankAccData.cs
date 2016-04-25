using System;

class BankAccData
{
    static void Main()
    {
        string firstName = "Boyko";
        string middleName = "I";
        string lastName = "Tikvarov";
        decimal availBalance = 568000000.68m;
        string bankName = "First Investment Bank";
        string numberIBAN = "CVBSFI87982989343";
        int firstAccont = 98999799;
        int secondAccount = 65000055;
        int thirdAccount = 05006996;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Second name: "+ middleName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Avail.Balance: " + availBalance);
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("IBAN: " + numberIBAN);
        Console.WriteLine("1 Account Number: " + firstAccont);
        Console.WriteLine("2 Account Number: " + secondAccount);
        Console.WriteLine("3 Account Number: " + thirdAccount);


    }
}

