using System;
//09.Declare two integer variables a and b and assign them with 
//   5 and 10 and after that exchange their values. 
//   Print the variable values before and after the exchange.

public class ExchangeVariableValues
{
    public static void Main()
    {
        int x = 5;
        int y = 20;
        Console.WriteLine($"Before the exchange x = {x}, y = {y}");

        Console.WriteLine();
        ExchangeWithXOR(x, y);
        ExchangeWithTempVariable(x, y);

        Console.WriteLine();
        Console.WriteLine("Example shows exchange in the function, not in the Main method.");
        Console.WriteLine("In the Main x and y have old values: x = {0}, y = {1}", x, y);
    }

    private static void ExchangeWithTempVariable(int x, int y)
    {
        int temp;
        temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Temp Variable - After the exchange x = {x}, y = {y}");
    }

    private static void ExchangeWithXOR(int x, int y)
    {
        x = x ^ y;
        y = x ^ y;
        x = x ^ y;
        Console.WriteLine($"XOR - After the exchange x = {x}, y = {y}");
    }
}
