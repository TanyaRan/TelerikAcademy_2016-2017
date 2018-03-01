namespace CharArraysCompare
{
    using System;

    public class CompareCharArrays
    {
        public static void Main()
        {
            var a = Console.ReadLine().ToCharArray();
            var b = Console.ReadLine().ToCharArray();

            int result = ComparingCharArrays(a, b);

            switch (result)
            {
                case -1:
                    Console.WriteLine(">");
                    break;
                case 0:
                    Console.WriteLine("=");
                    break;
                case 1:
                    Console.WriteLine("<");
                    break;
            }
        }

        public static int ComparingCharArrays(char[] a, char[] b)
        {
            int i = 0;
            //found difference
            while (i < a.Length && i < b.Length)
            {
                if (a[i] > b[i])
                {
                    return -1;
                }
                if (a[i] < b[i])
                {
                    return 1;
                }

                i++;
            }

            //if there is no difference
            if (a.Length == b.Length)
            {
                return 0;
            }
            else if (a.Length > b.Length)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
