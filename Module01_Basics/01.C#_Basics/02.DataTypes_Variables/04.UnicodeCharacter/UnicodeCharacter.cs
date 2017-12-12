using System;
//04.Declare a character variable and assign it with the symbol 
//   that has Unicode code 72, and then print it. 
//   Hint: first, use the Windows Calculator to find the 
//   hexadecimal representation of 72. The output should be “H”.
public class UnicodeCharacter
{
    public static void Main()
    {
        char symbolWithUnicode72 = '\u0048';
        Console.WriteLine($"Symbol with Unicode 72(dec) or 0048(hex) is {symbolWithUnicode72}.");
    }
}
