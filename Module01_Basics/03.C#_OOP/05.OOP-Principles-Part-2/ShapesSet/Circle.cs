namespace ShapesSet
{
    using System;
    
    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, width)
        {

        }

        public override double CalculateSurface(double width, double height)
        {
            return Math.PI * (width * width / 4);
        }
    }
}
