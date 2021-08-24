using Shapess.App.Classes;
using System;
using System.Collections.Generic;

namespace Shapess.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Shape> listShape = new List<Shape>();

            CircleShape circle = new CircleShape(3);
            RectangleShape rectangle = new RectangleShape(5, 6);
            Square square = new Square(3);
            IShapeStore store = new ShapeStore();
            store.AddShape(circle);
            store.AddShape(rectangle);
            store.AddShape(square);

            var allShapes = store.GetAllShapes();
            bool x = false;
            foreach (Shape shape in allShapes)
            {
                double surfaceArea = shape.Getperimeter();
                if (shape.GetName() == "Circle")
                {
                    Console.WriteLine("The perimeter of the " + shape.GetName() + " is :" + surfaceArea + " and the radius: " + shape.GetRadius());
                }
                else
                {
                    Console.WriteLine("The perimeter of the " + shape.GetName() + " is :" + surfaceArea + " No radius");
                }
            }
            //  Console.WriteLine(circle.GetName());
            // Console.WriteLine(circle.GetArea());

            // listShape.Add(rectangle);
            // listShape.Add(circle);
            // listShape.Add(square);
            // Console.WriteLine(listShape[0].GetArea());
            // Console.WriteLine(listShape[0].Getperimeter());
            //  Console.WriteLine(listShape[2].GetArea());
            // int x;

        }
    }
}
