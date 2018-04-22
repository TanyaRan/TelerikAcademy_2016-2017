namespace ShapesSet
{
    using System;
    
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Shapes width cannot be negative!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Shapes height cannot be negative!");
                }

                this.height = value;
            }
        }
    
        public abstract double CalculateSurface(double width, double height);        
    }
}
