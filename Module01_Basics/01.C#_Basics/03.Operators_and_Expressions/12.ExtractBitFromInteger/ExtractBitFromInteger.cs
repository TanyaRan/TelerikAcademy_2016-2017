using System;

public class ExtractBitFromInteger
{
    public static void Main()
    {
        ulong inputNumber = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        ulong bitN = GiveBitValue(inputNumber, n);

        Console.WriteLine(bitN);
    }

    public static ulong GiveBitValue(ulong number, int bitNumber)
    {
        int mask = 1 << bitNumber;
        ulong numberAndMask = number & (ulong)mask;
        ulong bitValue = numberAndMask >> bitNumber;

        return bitValue;
    }
}