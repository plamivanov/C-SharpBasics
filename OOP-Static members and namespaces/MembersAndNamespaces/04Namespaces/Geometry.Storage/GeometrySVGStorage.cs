using System;


namespace Geometry.Storage
{
    public class GeometrySVGStorage
    {
        //private double x;
        //private double y;
        //private double z;
        
        public GeometrySVGStorage(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return String.Format("(x*y)/z= {0}", (this.X*this.Y)/this.Z);
        }
    }
}
