using System;
//using System.Threading;
//using System.Globalization;
class PerimeterAndArea
{
    static void Main()
    {
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Write down the radius (r),please:");
        double r =double.Parse( Console.ReadLine());
        Console.WriteLine("The perimeter is: {0:0.00} sm.", r*2*3.141592);
        Console.WriteLine("The area is : {0:0.00} sq.sm.",r*r*3.141592);
    }
}

