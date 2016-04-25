using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(15.3, 0.4);
            Rectangle rec3 = new Rectangle(43.3, 12.4);
            Rectangle rec4 = new Rectangle(13.5, 10.8);
            Circle cir1 = new Circle(5);
            Rhombus omb1 = new Rhombus(5,4);
            Rectangle rec2 = new Rectangle(23.3, 10.4);
            Circle cir2 = new Circle(5);
            Rhombus omb2 = new Rhombus(5, 2); 
            Circle cir3 = new Circle(10);
            Rhombus omb5 = new Rhombus(9, 3); 
            Circle cir4 = new Circle(23);
            IShape omb4 = new Rhombus(8, 2);
            Circle cir9 = new Circle(5);
            Rhombus omb8 = new Rhombus(12, 5.6);
            Rhombus omb7 = new Rhombus(9, 3);
            IShape omb468 = new Rhombus(14, 12);

            //Console.WriteLine(rec1.CalculatePerimeter());

            List<IShape> aerialble = new List<IShape> { cir2, cir3, cir4, cir9, omb1, omb2, omb5, rec1, rec2, rec3, rec4 };

            foreach (var item in aerialble)//soad
            {
                Console.WriteLine("Figure:{2:0.00} Has Parimeter:{0:0.00} And Area:{1:0.00}", item.CalculatePerimeter(), item.CalculateArea(),item.GetType().Name);
            }


            
           
        }
    }
}
