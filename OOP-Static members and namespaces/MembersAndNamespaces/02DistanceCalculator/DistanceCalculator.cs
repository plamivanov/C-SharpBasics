using System;
using _01Point3D;

namespace _02DistanceCalculator
{
   
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D tochka1, Point3D tochka2)
        {
            double x1x2 = Math.Pow((tochka1.X - tochka2.X), 2);
            double y1y2 = Math.Pow((tochka1.Y - tochka2.Y), 2);
            double z1z2 = Math.Pow((tochka1.Z - tochka2.Z), 2);

            return Math.Sqrt(x1x2 + y1y2 + z1z2);
        }
    }
    
}
