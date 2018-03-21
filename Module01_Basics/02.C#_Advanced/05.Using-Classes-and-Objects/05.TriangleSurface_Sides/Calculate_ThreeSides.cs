using System;

namespace TriangleSurface_Sides
{
    public class Calculate_ThreeSides
    {
        public static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(sideA, sideB, sideC);

            Console.WriteLine("{0:F2}", triangleArea);
        }

        private static double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return area;
        }
    }
}
