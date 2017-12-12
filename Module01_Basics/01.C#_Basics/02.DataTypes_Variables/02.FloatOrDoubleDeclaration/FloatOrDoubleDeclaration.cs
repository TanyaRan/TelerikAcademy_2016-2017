using System;
//02.Which of the following values can be assigned to a variable of type float and 
//   which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
//   Write a program to assign the numbers in variables and print them to ensure no precision is lost.

public class FloatOrDoubleDeclaration
{
    public static void Main()
    {
        double d1 = 34.567839023;
        float f1 = 12.345f;
        double d2 = 8923.1234857;
        float f2 = 3456.091f;

        Console.WriteLine($@"Double variables: d1 = {d1}, d2 = {d2}
Float variables: f1 = {f1}, f2 = {f2}");
    }
}