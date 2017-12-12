using System;

public class BitSwap
{
    public static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint bitP, bitQ;
        uint exchangeNumber = n;
        for (int i = 0; i < k; i++)
        {
            int pSequence = p + i;
            int qSequence = q + i;

            bitP = GiveBitValue(n, pSequence);
            bitQ = GiveBitValue(n, qSequence);

            uint temp;
            temp = bitP; bitP = bitQ; bitQ = temp;

            exchangeNumber = ModifyNumber(exchangeNumber, bitP, pSequence);
            exchangeNumber = ModifyNumber(exchangeNumber, bitQ, qSequence);
        }

        Console.WriteLine(exchangeNumber);
    }

    public static uint GiveBitValue(uint number, int bitNumber)
    {
        int mask = 1 << bitNumber;
        uint numberAndMask = number & (uint)mask;
        uint bitValue = numberAndMask >> bitNumber;

        return bitValue;
    }

    public static uint ModifyNumber(uint numberToModify, uint bit, int bitNumber)
    {
        uint inputNumber = numberToModify;
        int p = bitNumber;
        uint v = bit;

        uint mask = 1U << p;

        uint modifiedNumber = inputNumber & ~(mask);
        modifiedNumber = modifiedNumber | (v << p);

        return modifiedNumber;
    }
}

