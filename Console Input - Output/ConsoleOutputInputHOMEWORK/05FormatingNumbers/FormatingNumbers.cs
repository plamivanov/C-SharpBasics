using System;

class FormatingNumbers
{
    static void Main()
    {
        string aHex = "Hex of 'a'";
        string aBin = "Bin of 'a'";
        string bTwo = "b in 0.00";
        string cThree = "c in 0.00";

        Console.WriteLine("What is your a , b and c :)");
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        
        string binary = Convert.ToString(a, 2).PadLeft(10,'0'); //Important to know
        string hex = a.ToString("X");           //Important to know
        
        Console.WriteLine("|{0,10}|{1,10}|{2,10}|{3,10}|",aHex,aBin,bTwo,cThree);
        Console.WriteLine("|{0,-10}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", hex, binary, b, c);
    }
}

