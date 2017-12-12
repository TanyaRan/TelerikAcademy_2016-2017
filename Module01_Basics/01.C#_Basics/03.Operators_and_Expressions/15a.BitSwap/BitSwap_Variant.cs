using System;

public class BitSwap_Variant
{
    public static void Main()
    {
        Console.WriteLine("-----------------------------  PROGRAM  ------------------------------");
        Console.WriteLine("Exchange bits {p,p+1,…,p+k-1) with bits {q,q+1,…,q+k-1} of integer n.");

        Console.Write("Enter a positive integer n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter position p=");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter tne number k, (k>0), k=");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Enter position q,(q>p+k-1), q=");
        int q = int.Parse(Console.ReadLine());

        bool badInput = ((p + k - 1) >= q) || ((q + k - 1) > 30);

        while (badInput)
        {
            Console.WriteLine("The first and the second sequence of bits may not overlap!!!");
            Console.WriteLine("And (q + k - 1) <= 30");
            Console.WriteLine("Enter again:");
            Console.Write("p = ");
            p = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            q = int.Parse(Console.ReadLine());

            badInput = ((p + k - 1) >= q) || ((q + k - 1) > 30);
        }

        int bitP, bitQ;
        int exchangeNumber = n;
        for (int i = 0; i < k; i++)
        {
            int pSequence = p + i;
            int qSequence = q + i;

            bitP = GiveBitValue(n, pSequence);
            bitQ = GiveBitValue(n, qSequence);

            int temp;
            temp = bitP; bitP = bitQ; bitQ = temp;

            exchangeNumber = ModifyNumber(exchangeNumber, bitP, pSequence);
            exchangeNumber = ModifyNumber(exchangeNumber, bitQ, qSequence);
        }

        Console.WriteLine("The exchange number is {0}", exchangeNumber);
        Console.WriteLine();
        Console.WriteLine(" Original number n = {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("The exchangeNumber = {0}", Convert.ToString(exchangeNumber, 2).PadLeft(32, '0'));

        //example -> n=1023, p=0, q=20, k=5,
        // 00000000 00000000 00000011 11111111
        // 00000001 11110000 00000011 11100000
    }

    public static int GiveBitValue(int number, int bitNumber)
    {
        int mask = 1 << bitNumber;
        int numberAndMask = number & mask;
        int bitValue = numberAndMask >> bitNumber;

        return bitValue;
    }

    public static int ModifyNumber(int numberToModify, int bit, int bitNumber)
    {
        int mask;
        int resultNumber;

        if (bit == 1)
        {
            mask = 1 << bitNumber;
            resultNumber = numberToModify | mask;
        }
        else
        {
            mask = ~(1 << bitNumber);
            resultNumber = numberToModify & mask;
        }

        return resultNumber;
    }
}
