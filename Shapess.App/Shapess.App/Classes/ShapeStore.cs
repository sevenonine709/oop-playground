using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess.App.Classes
{
    public class ShapeStore : IShapeStore
    {

        private List<Shape> listShape;
        public ShapeStore()
        {
            listShape = new List<Shape>();
        }
        public void AddShape(Shape shapetype)
        {
            listShape.Add(shapetype);
        }

        public List<Shape> GetAllShapes()
        {
            return listShape;
        }

        public void RemoveSahpes()
        {
            listShape.Clear();
                
        }
    }
}
