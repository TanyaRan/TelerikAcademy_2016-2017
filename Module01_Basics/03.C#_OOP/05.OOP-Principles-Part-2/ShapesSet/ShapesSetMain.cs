//01.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//   Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//   (height*width for rectangle and height*width/2 for triangle). 
//   Define class Circle and suitable constructor so that at initialization height must be kept equal to width
//   and implement the CalculateSurface() method. 
//   Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle)
//   stored in an array.
namespace ShapesSet
{
    using System;
    using System.Collections.Generic;
    
    public class ShapesSetMain
    {
        static void Main()
        {
            IEnumerable<Shape> shapesList =  new List<Shape>()          
            {
                new Rectangle(2, 4),
                new Circle(3, 3),
                new Rectangle(6, 3),
                new Triangle(3, 4)
            };

            foreach (var shape in shapesList)
            {
                var surface = shape.CalculateSurface(shape.Width, shape.Height);
                Console.WriteLine("{0}({1}, {2}) -> surface = {3:F2}", shape.GetType().Name, shape.Width, shape.Height, surface);
            }
        }
    }
}
