using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public class Rectangle:BasicShape
    {
        public Rectangle(double width,double height):base(width,height)
        {
            
        }
        
        public override double CalculatePerimeter()
        {
            return base.Width*2+base.Height*2;
        }
        public override double CalculateArea()
        {
            return base.Height * base.Width;
        }
        
    }
}
