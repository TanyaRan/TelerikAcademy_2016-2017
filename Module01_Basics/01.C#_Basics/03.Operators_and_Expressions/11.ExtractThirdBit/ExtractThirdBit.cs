using System;

public class ExtractThirdBit
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int bit3 = (inputNumber >> 3) & 1;
        Console.WriteLine(bit3);
    }
}