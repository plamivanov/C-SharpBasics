using System;
using System.Collections.Generic;
using _01Point3D;
using _02DistanceCalculator;

namespace _03Paths
{
   public class Path3D
    {
        private List<Point3D> points3D;
        private double distance;

        public Path3D(List<Point3D>points3D)
        {
            this.points3D = points3D;
            this.distance = calcDistance(this.points3D);
        }
        public double Distance
        {
            get { return this.distance; }
        }

       private double calcDistance(List<Point3D>points3D)
       {
           double pyt=0;
           for (int i = 0; i < points3D.Count-1; i++)
           {
               pyt += DistanceCalculator.CalculateDistance(points3D[i], points3D[i + 1]);
           }
           return pyt;
       }

       public override string ToString()
       {
           string pyt = "The distance between the following 3D points:\n";
           for (int i = 0; i < points3D.Count; i++)
           {
               pyt+=points3D[i].X+" , "+points3D[i].Y+" , "+points3D[i].Z+ "\n";
           }
           pyt += "is : " + this.Distance;
           return pyt;
       }
    }
}
