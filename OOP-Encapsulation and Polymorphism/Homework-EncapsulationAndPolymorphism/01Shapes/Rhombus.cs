using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public class Rhombus:BasicShape
    {
        public Rhombus(double width,double height):base(width,height)
        {

        }
     
       
        public override double CalculatePerimeter()
        {
             return base.Width * 4;
        }
        public override double CalculateArea()
        {
            return base.Width * base.Height;
        }
    }
}
