using System;
//12.Create a program that assigns null values to an integer and to a double variable. 
//   Try to print these variables at the console. 
//   Try to add some number or the null literal to these variables and print the result.

public class NullValuesArithmetic
{
    public static void Main()
    {
        int? nullOrInt = null;
        double? nullOrDouble = null;

        Console.WriteLine("When add the null literal:");
        Console.WriteLine($"Nullable int = {nullOrInt}(null), Nullable double = {nullOrDouble}(null)");

        nullOrInt = 23;
        nullOrDouble = -99.4;

        Console.WriteLine("When add some number:");
        Console.WriteLine($"Nullable int = {nullOrInt}, Nullable double = {nullOrDouble}");
    }
}
