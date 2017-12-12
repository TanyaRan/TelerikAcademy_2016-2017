using System;

public class DivideBy7and5
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        bool canDivideBy5and7 = (inputNumber % 35 == 0);

        if (canDivideBy5and7)
        {
            Console.WriteLine("true {0}", inputNumber);
        }
        else
        {
            Console.WriteLine("false {0}", inputNumber);
        }
    }
}