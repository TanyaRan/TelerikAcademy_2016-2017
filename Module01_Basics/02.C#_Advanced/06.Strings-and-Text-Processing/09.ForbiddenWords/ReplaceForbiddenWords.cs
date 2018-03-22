using System;
using System.Text;

namespace ForbiddenWords
{
    public class ReplaceForbiddenWords
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var text = new StringBuilder(input);

            var forbidden = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < forbidden.Length; i++)
            {
                text = text.Replace(forbidden[i], new string('*', forbidden[i].Length));
            }

            Console.WriteLine(text.ToString());
        }
    }
}
