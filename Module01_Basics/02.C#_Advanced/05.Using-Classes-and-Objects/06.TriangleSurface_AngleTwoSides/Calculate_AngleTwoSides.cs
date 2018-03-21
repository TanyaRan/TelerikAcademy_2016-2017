using System;

namespace TriangleSurface_AngleTwoSides
{
    public class Calculate_AngleTwoSides
    {
        public static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleGama = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(sideA, sideB, angleGama);

            Console.WriteLine("{0:F2}", triangleArea);
        }

        private static double GetTriangleArea(double sideA, double sideB, double angleGama)
        {
            double radiansGama = Math.PI * angleGama / 180.0;
            double area = (sideA * sideB * Math.Sin(radiansGama)) / 2;

            return area;
        }
    }
}
