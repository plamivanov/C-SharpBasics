using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public class Circle:IShape
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        
        public double Radius { get; set; }

        public double CalculatePerimeter()
        {
            return 2 * this.Radius * Math.PI;
        }
        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
