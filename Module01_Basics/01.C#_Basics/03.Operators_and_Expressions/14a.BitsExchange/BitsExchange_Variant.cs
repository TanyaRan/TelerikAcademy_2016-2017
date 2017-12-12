using System;

public class BitsExchange_Variant
{
    public static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        uint bit3 = GiveBitValue(n, 3),
            bit4 = GiveBitValue(n, 4),
            bit5 = GiveBitValue(n, 5),
            bit24 = GiveBitValue(n, 24),
            bit25 = GiveBitValue(n, 25),
            bit26 = GiveBitValue(n, 26);

        uint temp;
        temp = bit3; bit3 = bit24; bit24 = temp;
        temp = bit4; bit4 = bit25; bit25 = temp;
        temp = bit5; bit5 = bit26; bit26 = temp;

        uint exchangeNumber = n;
        exchangeNumber = ModifyNumber(exchangeNumber, bit3, 3);
        exchangeNumber = ModifyNumber(exchangeNumber, bit4, 4);
        exchangeNumber = ModifyNumber(exchangeNumber, bit5, 5);
        exchangeNumber = ModifyNumber(exchangeNumber, bit24, 24);
        exchangeNumber = ModifyNumber(exchangeNumber, bit25, 25);
        exchangeNumber = ModifyNumber(exchangeNumber, bit26, 26);

        Console.WriteLine(exchangeNumber);
    }

    public static uint GiveBitValue(uint number, int bitNumber)
    {
        uint mask = 1u << bitNumber;
        uint numberAndMask = number & mask;
        uint bitValue = numberAndMask >> bitNumber;

        return bitValue;
    }

    public static uint ModifyNumber(uint numberToModify, uint bit, byte bitNumber)
    {
        uint inputNumber = numberToModify;
        byte p = bitNumber;
        uint v = bit;

        uint mask = 1U << p;

        uint modifiedNumber = inputNumber & ~(mask);
        modifiedNumber = modifiedNumber | (v << p);

        return modifiedNumber;
    }
}