namespace _05.SortByStringLength
{
    using System;

    public class SortArrayByStringLength
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            SortStringsByLength(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        private static string[] SortStringsByLength(string[] inputArr)
        {
            //Bubble Sort
            for (int sorted = 1; sorted < inputArr.Length - 1; sorted++)
            {
                // Unsorted array becomes shorter and shorter
                for (int i = 0; i < inputArr.Length - sorted; i++)
                {
                    if (inputArr[i].Length > inputArr[i + 1].Length)
                    {
                        // Largest element float to the highest index
                        string temp = inputArr[i];
                        inputArr[i] = inputArr[i + 1];
                        inputArr[i + 1] = temp;
                    }
                }
            }
            return inputArr;
        }
    }
}
