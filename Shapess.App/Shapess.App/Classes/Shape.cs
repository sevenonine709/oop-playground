using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public class Shape
    {
        protected string ShapeName { get; set; }

        public string GetName() 
        {
            return ShapeName;
        }
        public virtual double GetArea() { return 0; }
        public virtual double Getperimeter() { return 0; }

        public virtual double GetRadius() { return 0; }






    }
}
