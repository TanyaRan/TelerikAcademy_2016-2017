using System;

namespace TriangleSurface_SideAltitude
{
    public class Calculate_SideAltitude
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(side, altitude);

            Console.WriteLine("{0:F2}", triangleArea);
        }

        private static double GetTriangleArea(double side, double altitude)
        {
            double area = (side * altitude) / 2;

            return area;
        }
    }
}
