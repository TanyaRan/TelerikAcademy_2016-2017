using System;

namespace SolveTasks
{
    public class SolveThreeTasks
    {
        public static void Main()
        {
            Console.WriteLine("- - - - MENU - - - -\n There are 3 subprograms to choose from:");
            Console.WriteLine("Enter 1 if you want to reverse a number.");
            Console.WriteLine("Enter 2 if you want to get an average of a sequence.");
            Console.WriteLine("Enter 3 if you want to solve a linear equation.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number that you want to be reversed:");
                    int number = int.Parse(Console.ReadLine());
                    ReverseNumber(number);
                    break;
                case 2:
                    Console.WriteLine("Enter the number of elements of your sequence:");
                    int n = int.Parse(Console.ReadLine());
                    CalculateAverage(n);
                    break;
                case 3:
                    Console.WriteLine("Enter the coefficients a and b on a separate line:");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    LinearEquation(a, b);
                    break;
                default:
                    break;
            }
        }

        static void ReverseNumber(int number)
        {
            int result = 0;

            while (number < 0)
            {
                Console.WriteLine("Negative number! Try again!");
                number = int.Parse(Console.ReadLine());
            }

            while (number > 0)
            {
                result = result * 10 + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Reversed number is: {0}.", result);
        }

        static void CalculateAverage(int numElements)
        {
            while (numElements == 0)
            {
                Console.WriteLine("Empty sequence! Try again! ");
                Console.WriteLine("Enter the number of elements of your sequence (number != 0) :");
                numElements = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter sequence elements :");
            int[] array = new int[numElements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            double sum = 0;
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = sum / array.Length;
            Console.WriteLine("The average of your sequence is: {0:F3}.", average);
        }

        static void LinearEquation(double a, double b)
        {
            while (a == 0)
            {
                Console.WriteLine("Invalid coefficient a! Try again!");
                Console.WriteLine("Enter the coeficient a (a != 0) : ");
                a = double.Parse(Console.ReadLine());
            }

            double result = (b * (-1)) / a;
            Console.WriteLine("The root of your equation is: {0:F3}.", result);
        }
    }
}
