﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shapes
{
    public abstract class BasicShape:IShape
    {
        private double width;
        private double height;

        public BasicShape(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }

       public abstract double CalculatePerimeter();
       public abstract double CalculateArea();

    
    }
}
