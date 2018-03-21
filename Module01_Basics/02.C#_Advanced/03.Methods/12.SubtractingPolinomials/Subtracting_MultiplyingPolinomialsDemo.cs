using System;
using System.Linq;

namespace SubtractingPolinomials
{
    public class Subtracting_MultiplyingPolinomialsDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] polinomial1 = (Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());
            int[] polinomial2 = (Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());

            int[] resultSubs = SubstractCoeficients(polinomial1, polinomial2);

            Console.WriteLine(string.Join(" ", resultSubs));

            int[] resultMult = MultiplyingCoeficients(polinomial1, polinomial2);

            Console.WriteLine(string.Join(" ", resultMult));
        }

        private static int[] SubstractCoeficients(int[] polinomial1, int[] polinomial2)
        {
            int len = polinomial1.Length;
            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = polinomial1[i] - polinomial2[i];
            }

            return result;
        }

        private static int[] MultiplyingCoeficients(int[] polinomial1, int[] polinomial2)
        {
            int len = polinomial1.Length * 2 - 1;
            int[] result = new int[len];

            for (int i = 0; i < polinomial1.Length; i++)
            {
                for (int j = 0; j < polinomial2.Length; j++)
                {
                    result[i + j] += polinomial1[i] * polinomial2[j];
                }
            }

            return result;
        }
    }
}
