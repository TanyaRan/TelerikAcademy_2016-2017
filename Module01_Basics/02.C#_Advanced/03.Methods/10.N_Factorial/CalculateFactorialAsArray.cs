using System;
using System.Collections.Generic;

namespace N_Factorial
{
    public class CalculateFactorialAsArray
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            int number = int.Parse(n);

            List<int> nList = new List<int>();

            for (int i = n.Length - 1; i >= 0; i--)
            {
                nList.Add(int.Parse(n[i].ToString()));
            }

            List<int> result = nList;
            for (int i = number - 1; i > 0; i--)
            {
                result = MultipleNumberAsArray(result, i);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }

        private static List<int> MultipleNumberAsArray(List<int> arr, int index)
        {
            List<int> resultArr = new List<int>();
            int carry = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int temp = arr[i] * index + carry;
                resultArr.Add(temp % 10);
                carry = temp / 10;
            }

            while (carry != 0)
            {
                resultArr.Add(carry % 10);
                carry = carry / 10;
            }

            return resultArr;
        }
    }
}
