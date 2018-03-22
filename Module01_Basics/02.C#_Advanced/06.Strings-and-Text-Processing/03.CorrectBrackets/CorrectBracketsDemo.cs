using System;

namespace CorrectBrackets
{
    public class CorrectBracketsDemo
    {
        public static void Main()
        {
            string expression = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    count++;
                }
                if (expression[i] == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    // if count<0 -> the expression is wrong!
                    break;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
