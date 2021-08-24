using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public interface IShapeStore
    {
        public List<Shape> GetAllShapes();

        public void AddShape(Shape shapetype);
        public void RemoveSahpes();
        
    }
}
