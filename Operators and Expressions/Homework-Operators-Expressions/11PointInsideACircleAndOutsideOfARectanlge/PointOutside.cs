using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PointInsideACircleAndOutsideOfARectanlge
{
    class PointOutside
    {
        static void Main(string[] args)
        {
           //(x - center_x)^2 + (y - center_y)^2 < radius^2


            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool outsideRectangle=(x>5||x<-1)||(y>1 ||y<-1);
            bool inCirle = ((x - 1)*(x-1))+((y - 1)*(y-1)) <= 1.5 * 1.5;
            if (inCirle && outsideRectangle)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
