using System;
//13-old.Write a Boolean expression that returns if the bit at position p 
//   (counting from 0, starting from the right) in given integer number n has value of 1. 

public class CheckBitAtGivenPosition
{
    public static void Main()
    {
        Console.Write("Enter an integer x = ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the index p = ");
        int p = int.Parse(Console.ReadLine());

        bool isOne = ((inputNumber >> p) & 1) == 1;

        Console.WriteLine("Binary representation of {0} is :", inputNumber);
        Console.WriteLine(Convert.ToString(inputNumber, 2).PadLeft(16, '0'));

        if (isOne)
        {
            Console.WriteLine("Yes, bit at position {0} is 1.", p);
        }
        else
        {
            Console.WriteLine("No, bit at position {0} is not 1.", p);
        }
    }
}
