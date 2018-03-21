using System;
using System.Linq;

namespace AddingPolynomials
{
    public class AddingPolynomialsDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] polinomial1 = (Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());
            int[] polinomial2 = (Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());

            int[] result = AddCoeficients(polinomial1, polinomial2);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] AddCoeficients(int[] polinomial1, int[] polinomial2)
        {
            int len = polinomial1.Length;
            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = polinomial1[i] + polinomial2[i];
            }

            return result;
        }
    }
}
