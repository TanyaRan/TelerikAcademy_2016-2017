using System;

// 14*.Find online more information about ASCII (American Standard Code for Information Interchange) and 
// write a program that prints the visible characters of the ASCII table on the console (characters from 0 to 255 including).

// Note: You may need to use for-loops(learn in Internet how).
// Some characters have a special purpose and will not be displayed as expected. 

public class PrintASCIITable
{
    public static void Main()
    {
        // Internet helps - interesting print ASCII Table
        Console.Write("Dec".PadRight(5));
        Console.Write("ASCII".PadRight(9));
        Console.Write("Hex".PadRight(5));
        Console.WriteLine();

        int min = 0;
        int max = 255;
        for (int i = min; i <= max; i++)
        {
            // Get ASCII character.
            char c = (char)i;

            // Get display string.
            string display = string.Empty;
            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }
            // Write table row.
            Console.Write(i.ToString().PadRight(5));
            Console.Write(display.PadRight(9));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
}
