using System;
//07.Declare two string variables and assign them with following value:
//   The "use" of quotations causes difficulties.
//   Do the above in two different ways: with and without using quoted strings.
//   Print the variables to ensure that their value was correctly defined.

public class QuotesAndStrings
{
    public static void Main()
    {
        string quotesUse = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine($"{quotesUse}");
    }
} 
