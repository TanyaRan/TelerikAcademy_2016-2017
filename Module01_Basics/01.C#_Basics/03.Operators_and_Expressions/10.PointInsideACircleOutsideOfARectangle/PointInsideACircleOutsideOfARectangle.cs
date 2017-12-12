using System;

public class PointInsideACircleOutsideOfARectangle
{
    public static void Main()
    {
        decimal centerX = 1.0m,
                centerY = 1.0m,
                radius = 1.5m;

        decimal pointX = decimal.Parse(Console.ReadLine());
        decimal pointY = decimal.Parse(Console.ReadLine());

        decimal result = (pointX - centerX) * (pointX - centerX) + (pointY - centerY) * (pointY - centerY);
        bool withinCircle = result <= radius * radius;

        decimal leftX = -1m,
                width = 6m,
                rightX = leftX + width;
        decimal topY = 1m,
                height = 2m,
                bottomY = topY - height;
        bool inTheRect = (pointX >= leftX) && (pointX <= rightX) && (pointY >= bottomY) && (pointY <= topY);

        if (withinCircle)
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }

        if (inTheRect)
        {
            Console.WriteLine(" inside rectangle");
        }
        else
        {
            Console.WriteLine(" outside rectangle");
        }
    }
}