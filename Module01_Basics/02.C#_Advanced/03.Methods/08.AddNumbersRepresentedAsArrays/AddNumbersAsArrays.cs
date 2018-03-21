using System;
using System.Collections.Generic;
using System.Linq;

namespace AddNumbersRepresentedAsArrays
{
    public class AddNumbersAsArrays
    {
        public static void Main()
        {
            var lengths = Console.ReadLine();
            List<int> arr = new List<int>(lengths.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)));

            int n = arr[0];
            int m = arr[1];
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int[] firstNumber;
            int[] secondNumber;

            if (n >= m)
            {
                firstNumber = (number1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());
                secondNumber = (number2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)).ToArray());
            }
            else
            {
                firstNumber = (number2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());
                secondNumber = (number1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)).ToArray());
            }

            List<int> result = SumNumbers(firstNumber, secondNumber);

            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString())));
        }

        private static List<int> SumNumbers(int[] firstNumber, int[] secondNumber)
        {
            List<int> result = new List<int>();
            int carry = 0;

            for (int i = 0; i < firstNumber.Length; i++)
            {
                int temp;
                if (i < secondNumber.Length)
                {
                    temp = firstNumber[i] + secondNumber[i];
                }
                else
                {
                    temp = firstNumber[i];
                }

                result.Add(temp + carry);

                if (result[i] > 9)
                {
                    result[i] %= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                result.Add(carry);
            }

            return result;
        }
    }
}
