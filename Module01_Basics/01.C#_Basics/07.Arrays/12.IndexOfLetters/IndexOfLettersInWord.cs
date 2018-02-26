namespace IndexOfLetters
{
    using System;

    public class IndexOfLettersInWord
    {
        public static void Main()
        {
            char[] arr = new char[26];

            for (int i = 0; i < 26; i++)
            {
                arr[i] = Convert.ToChar('a' + i);
            }

            var word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] - 'a');
            }
        }
    }
}
