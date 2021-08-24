using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public class CircleShape : Shape
    {
        private int RadiusCircle { get; set; }
        public CircleShape (int radiusCircle)
        {
            RadiusCircle = radiusCircle;
            ShapeName = "Circle";
        }
        public override double GetArea()
        {
            return (Math.PI * RadiusCircle)*(Math.PI * RadiusCircle);
        }

        public override double Getperimeter()
        {
            return (2 * Math.PI) * RadiusCircle;
        }
        public override double GetRadius()
        {
            return RadiusCircle;
        }



}
}
