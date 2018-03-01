namespace UsingBinSearch
{
    using System;
    using System.Linq;

    public class BinSearchDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int k = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);

            if (index >= 0)
            {
                Console.WriteLine(index); // found
            }
            else
            {
                // not found 
                // Array.BinarySearch() returns negative number which is the bitwise complement of the index of the first element that is larger than value. 
                Console.WriteLine("The largest number in array less than {0} is at index {1}", k, -index-2);
            }
        }
    }
}
