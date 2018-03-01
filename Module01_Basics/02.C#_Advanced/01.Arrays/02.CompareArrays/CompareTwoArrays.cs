namespace CompareArrays
{
    using System;

    public class CompareTwoArrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
