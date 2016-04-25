using System;
using System.Collections.Generic;

using _01Point3D;
using _02DistanceCalculator;
namespace _03Paths
{
    class CalcPointsMain
    {
        static void Main(string[] args)
        {
            Point3D points1 = new Point3D(34.45, 20, 30);
            Point3D points2 = new Point3D(21, 50.34, 38.778);
            Point3D points3 = new Point3D(21, 65.34, 38.712);
            Point3D points4 = new Point3D(15, 68.34, 38.712);

            List<Point3D> listP1 = new List<Point3D> { points1, points2, points4 };
            List<Point3D> listP2 = new List<Point3D> { points3, points4 };
            List<Point3D> listP3 = new List<Point3D> { points2, points3 };

            Path3D path = new Path3D(listP1);
            Path3D path1 = new Path3D(listP2);
            Path3D path2 = new Path3D(listP3);

            Console.WriteLine(path);
            Console.WriteLine(path1);

            Storage.SavePath("../../SavePath.txt", path, path2, path2);
            Path3D newPath = Storage.LoadPath("../../LoadPaths.txt");           //видяно явно са го учили в адвансд..честито...
            Storage.SavePath("../../SavePath.txt", newPath);

            Console.WriteLine(newPath);

            
        }
    }
}
