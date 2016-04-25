using System;

namespace _01Point3D
{
    class PointsMain
    {
        static void Main()
        {
            Point3D point1 = new Point3D(5, 4.8, 8.8);
            var point2 = new Point3D(68, 44.5, 5.16);
            var zeroes = Point3D.StartingPoint;
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(zeroes);
        }
    }
}
