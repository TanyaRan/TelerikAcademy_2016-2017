using System;

public class ModifyBitAtPosition
{
    public static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        ulong value = ulong.Parse(Console.ReadLine());

        number &= ~(1U << position);
        number |= (value << position);
        Console.WriteLine(number);
    }
}