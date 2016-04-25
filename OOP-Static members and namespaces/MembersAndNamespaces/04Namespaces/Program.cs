using System;
//using Geometry.Geometry2D;
using Geometry.Geometry3D;
using Geometry.Storage;
using Geometry.UI;                          //enjoy 
namespace _04Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometryBinaryStorage edabe = new GeometryBinaryStorage();
            Geometry.Geometry2D.Rectangle edikakvosi = new Geometry.Geometry2D.Rectangle();
            GeometrySVGStorage ehaa=new GeometrySVGStorage(15.2,16.8,10);
            Console.WriteLine(ehaa);
            

        }
    }
}
