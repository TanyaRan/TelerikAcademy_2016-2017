namespace ShapesSet
{
    using System;
    
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
