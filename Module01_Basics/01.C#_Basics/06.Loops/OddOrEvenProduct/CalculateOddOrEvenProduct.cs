namespace OddOrEvenProduct
{
    using System;
    using System.Linq;

    public class CalculateOddOrEvenProduct
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int oddProduct = 1;
            int evenProduct = 1;
            var inputNumbers = (Console.ReadLine())
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= inputNumbers[i];
                }
                else
                {
                    evenProduct *= inputNumbers[i];
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
            }
        }
    }
}
