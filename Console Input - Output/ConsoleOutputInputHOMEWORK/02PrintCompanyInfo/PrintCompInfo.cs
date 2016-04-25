using System;

class PrintCompInfo
{
    static void Main()
    {


        Console.Write("Company name:");
        string nAme = Console.ReadLine();
        Console.Write("Company address:");
        string adress = Console.ReadLine();
        Console.Write("Phone number:");
        string number = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumber1 = Console.ReadLine();
        
        Console.Write("Web site:");
        string webReal = Console.ReadLine();
        Console.Write("Manager first name:");
        string naMe = Console.ReadLine();
        Console.Write("Manager last name:");
        string nameL = Console.ReadLine();
        Console.Write("Manager age:");
        int years = int.Parse(Console.ReadLine());
        Console.Write("Manager phone:");
        string phone = Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine("{0,-35}|{1,-36}|", "Company name:", nAme);
        Console.WriteLine("{0,-35}|{1,-36}|", "Company address:", adress);
        Console.WriteLine("{0,-35}|{1,-36}|", "Phone number:", number);
        Console.WriteLine("{0,-35}|{1,-36}|", "Fax number:", faxNumber1);
        Console.WriteLine("{0,-35}|{1,-36}|", "Web site:", webReal);
        Console.WriteLine("{0,-35}|{1,-36}|", "Manager first name:", naMe);
        Console.WriteLine("{0,-35}|{1,-36}|", "Manager last name:", nameL);
        Console.WriteLine("{0,-35}|{1,-36}|", "Manager age:", years);
        Console.WriteLine("{0,-35}|{1,-36}|", "Manager phone:", phone);
       
           
        
        
        
        
        		 
            
    }
}

