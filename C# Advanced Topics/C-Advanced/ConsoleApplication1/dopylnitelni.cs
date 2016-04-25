using System;



    class dopylnitelni
    {
        static void Main(string[] args)
        {
            double weightLB = double.Parse(Console.ReadLine());
            double heightINCH = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            int work = int.Parse(Console.ReadLine());
            double result=0;
            double dcl=0;
            weightLB = weightLB / 2.2;
            heightINCH = heightINCH * 2.54;

            if (a == "m")
            {
                result = 66.5+(13.75*weightLB)+(5.003*heightINCH)-(6.755*age);
            }
            else if (a=="f")
            {
                result = 655 + (9.563 * weightLB) + (1.850 * heightINCH) - (4.676 * age);
            }

            if (work < 1)
            {
                dcl=result*1.2;
            }
            else if (work >= 1 && work <= 3)
            {
                dcl = result * 1.375;
            }
            else if (work >= 4 && work <= 6)
            {
                dcl = result * 1.55;
            }
            else if (work >= 7 && work <= 9)
            {
                dcl = result * 1.725;
            }
            else if (work >9)
            {
                dcl = result * 1.9;
            }
            Console.WriteLine(Math.Floor(dcl));
            
            
        }
    }

