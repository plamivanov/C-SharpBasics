using System;
using _01Point3D;   //added reference... from project 01Point3D....public class ot 1va zadacha!!!!

namespace _02DistanceCalculator
{
    class DistanceMain
    {
        static void Main()
        {
            Point3D tochka55 = new Point3D(45.23, 280.43, 12.18);
            Point3D tochkaG = new Point3D(23.345, 44.2333, 111.55);
            Point3D tochka7 = new Point3D(1, 1, 1);
            Point3D tochka10 = new Point3D(8, 9, 8);

            Console.WriteLine("The distance btween tochka55 and tochkaG is:");
            Console.WriteLine(DistanceCalculator.CalculateDistance(tochka55,tochkaG));

            double razstoqnie = DistanceCalculator.CalculateDistance(tochka7, tochka10);
            Console.WriteLine("The distance beteen tochka7 and tochka 10 is:\n{0}",razstoqnie);
            
        }
    }
}
