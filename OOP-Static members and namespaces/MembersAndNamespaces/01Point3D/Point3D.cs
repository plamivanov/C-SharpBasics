﻿using System;


namespace _01Point3D
{
    public class Point3D
    {
        private static Point3D startingPoint = new Point3D(0,0,0);

        private double x;
        private double y;
        private double z;

        
        public Point3D(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return String.Format("Point x={0}, y={1}, z={2}",this.X,this.Y,this.Z);
        }

    }
}
