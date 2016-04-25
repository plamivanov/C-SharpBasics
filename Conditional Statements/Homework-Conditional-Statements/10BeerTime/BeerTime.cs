using System;

class BeerTime       
{
    static void Main()
    {
        string time = Console.ReadLine();
        DateTime dateTime;
        bool correctTime = DateTime.TryParse(time, out dateTime);   
        if (!correctTime)
        {
            Console.WriteLine("not falid time");
        }
        else
        {
            DateTime time1PM = DateTime.Parse("01:00 pm");
            DateTime time3AM = DateTime.Parse("03:00 am");

            if (time3AM.TimeOfDay < dateTime.TimeOfDay && dateTime.TimeOfDay < time1PM.TimeOfDay)
            {
                Console.WriteLine("not the beer time");
            }
            else
            {
                Console.WriteLine("beer t i m e");
            }
        }
    }
}

