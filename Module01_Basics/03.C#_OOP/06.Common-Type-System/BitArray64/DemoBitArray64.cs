using System;

public class DemoBitArray64
{
    public static void Main()
    {
        ulong num1 = 10225;
        BitArray64 testBitArray = new BitArray64(num1);
        Console.WriteLine("number {0} ->", num1);
        int count = 0;
        foreach (var item in testBitArray)
        {
            Console.Write("{0} ", item);
            count++;
            if (count % 8 == 0)
            {
                Console.Write("  ");
            }
            if (count % 32 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine("Bit at position 60 is {0}", testBitArray[60]);

        count = 0;
        ulong num2 = 62555;
        BitArray64 myTestBitArray = new BitArray64(num2);
        Console.WriteLine("number {0} ->", num2);
        foreach (var item in myTestBitArray)
        {
            Console.Write("{0} ", item);
            count++;
            if (count % 8 == 0)
            {
                Console.Write("  ");
            }
            if (count % 32 == 0)
            {
                Console.WriteLine();
            }
        }
        
        Console.WriteLine("Hash code of {0} is {1}", testBitArray, testBitArray.GetHashCode());

        Console.WriteLine("testBitArray == myTestBitArray -> {0}", testBitArray == myTestBitArray);
        Console.WriteLine("testBitArray != myTestBitArray -> {0}", testBitArray != myTestBitArray);
        Console.WriteLine("testBitArray.Equals(myTestBitArray) -> {0}", testBitArray.Equals(myTestBitArray));
    }
}