using System;
using System.Text;
//08.Write a program that prints an isosceles triangle of 9 
//   copyright symbols ©.
// Note: The © symbol may be displayed incorrectly at the console so you may need to change 
// the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

// Note: Under old versions of Windows the © symbol may still be displayed incorrectly, 
// regardless of how much effort you put to fix it.

public class IsoscelesTriangle_WithLoops
{
    const int WIDTH = 7;

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        WithLoops();
    }

    private static void WithLoops()
    {
        Console.Clear();
        char c = '\u00a9';

        string outerSpace = new String(' ', (WIDTH - 1) / 2);
        Console.WriteLine(outerSpace + c);

        string innerSpace;
        for (int i = 0, j = 2; j > 0; i++, j--)
        {
            outerSpace = new String(' ', j);
            innerSpace = new String(' ', i * 2 + 1);

            Console.WriteLine(outerSpace + c + innerSpace + c);
        }

        for (int i = 0; i < WIDTH; i++)
        {
            if (i % 2 == 1) Console.Write(' ');
            else Console.Write(c);
        }

        Console.WriteLine();
    }
}