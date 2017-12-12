using System;

public class BitsExchange
{
    public static void Main()
    {
        Console.Write("Enter a positive integer n = ");
        int n = int.Parse(Console.ReadLine());
        int exchangeNumber = n;

        int mask = 1 << 3;
        int nAndMask = n & mask;
        int bit3 = nAndMask >> 3;

        mask = 1 << 4;
        nAndMask = n & mask;
        int bit4 = nAndMask >> 4;

        mask = 1 << 5;
        nAndMask = n & mask;
        int bit5 = nAndMask >> 5;

        mask = 1 << 23;
        nAndMask = n & mask;
        int bit23 = nAndMask >> 23;

        mask = 1 << 24;
        nAndMask = n & mask;
        int bit24 = nAndMask >> 24;

        mask = 1 << 25;
        nAndMask = n & mask;
        int bit25 = nAndMask >> 25;

        Console.WriteLine("number n(10NumSyst) = {0} -> n(2NumSyst) = {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("bit3={0}, bit4={1}, bit5={2}, bit23={3}, bit24={4}, bit25={5}",
            bit3, bit4, bit5, bit23, bit24, bit25);

        int temp;
        temp = bit3; bit3 = bit23; bit23 = temp;
        temp = bit4; bit4 = bit24; bit24 = temp;
        temp = bit5; bit5 = bit25; bit25 = temp;

        if (bit3 == 1)
        {
            mask = 1 << 3;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 3);
            exchangeNumber = exchangeNumber & mask;
        }

        if (bit4 == 1)
        {
            mask = 1 << 4;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 4);
            exchangeNumber = exchangeNumber & mask;
        }

        if (bit5 == 1)
        {
            mask = 1 << 5;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 5);
            exchangeNumber = exchangeNumber & mask;
        }

        if (bit23 == 1)
        {
            mask = 1 << 23;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 23);
            exchangeNumber = exchangeNumber & mask;
        }

        if (bit24 == 1)
        {
            mask = 1 << 24;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 24);
            exchangeNumber = exchangeNumber & mask;
        }

        if (bit25 == 1)
        {
            mask = 1 << 25;
            exchangeNumber = exchangeNumber | mask;
        }
        else
        {
            mask = ~(1 << 25);
            exchangeNumber = exchangeNumber & mask;
        }

        Console.WriteLine("Exchange number is {0} -> {1}", exchangeNumber, Convert.ToString(exchangeNumber, 2).PadLeft(32, '0'));

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0') + "\n" + Convert.ToString(exchangeNumber, 2).PadLeft(32, '0'));
    }
}
