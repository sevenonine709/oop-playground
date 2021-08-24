using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public class RectangleShape : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        public RectangleShape(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            ShapeName = "Rectangle";
        }
        public override double GetArea()
        {
            return SideA*SideB;
        }
        public override double Getperimeter()
        {
            return 2*SideA+2*SideB;
        }

    }
}
