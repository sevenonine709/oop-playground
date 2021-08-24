using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public class Square : Shape
    {
        private double SideA { get; set; }
        public Square(double sideA)
        {
            SideA = sideA;
            ShapeName = "Square";
        }
        public override double GetArea()
        {
            return SideA * SideA;
        }
        public override double Getperimeter()
        {
            return 4 * SideA ;
        }
    }
}
