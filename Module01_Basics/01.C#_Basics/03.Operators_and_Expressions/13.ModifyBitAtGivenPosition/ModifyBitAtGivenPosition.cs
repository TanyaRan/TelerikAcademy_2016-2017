using System;

public class ModifyBitAtGivenPosition
{
    public static void Main()
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        ulong v = ulong.Parse(Console.ReadLine());

        ulong mask = 1U << p;

        ulong modifiedNumber = inputNumber & ~(mask);
        modifiedNumber = modifiedNumber | (v << p);

        Console.WriteLine(modifiedNumber);
    }
}