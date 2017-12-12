using System;
using System.Text;
//08.Write a program that prints an isosceles triangle of 9 
//   copyright symbols ©.
// Note: The © symbol may be displayed incorrectly at the console so you may need to change 
// the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

// Note: Under old versions of Windows the © symbol may still be displayed incorrectly, 
// regardless of how much effort you put to fix it.

public class IsoscelesTriangle
{
    public static void Main()
    {
        char c = '\u00a9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine($@"   {c}   
  {c} {c}  
 {c}   {c} 
{c} {c} {c} {c}");
    }
}