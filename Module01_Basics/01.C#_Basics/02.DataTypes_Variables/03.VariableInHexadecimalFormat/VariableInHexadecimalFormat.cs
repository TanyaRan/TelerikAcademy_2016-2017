using System;
//03.Declare an integer variable and assign it with the value 254 
//   in hexadecimal format (0x##). Use Windows Calculator to find 
//   its hexadecimal representation. Print the variable and ensure 
//   that the result is “254”.

public class VariableInHexadecimalFormat
{
    public static void Main()
    {
        int valueHex254 = 0xFE;
        Console.WriteLine($"The integer 254 has hexadecimal representation {valueHex254:X}.");
    }
}
