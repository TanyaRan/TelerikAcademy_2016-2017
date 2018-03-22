using System;
using System.Text;

namespace EncodeDecode_Variant
{
    public class EncodeDecodeWithKey
    {
        public static void Main()
        {
            // idea - if cipher is longer then message -> continue encrypt
            string message = Console.ReadLine();
            string cipher = Console.ReadLine();
            Console.WriteLine(message);

            string encoded = Encrypt(message, cipher);
            Console.WriteLine(encoded);

            string decoded = Encrypt(encoded, cipher);
            Console.WriteLine(decoded);
        }

        private static string Encrypt(string message, string cipher)
        {
            var result = new StringBuilder(message);
            var steps = Math.Max(message.Length, cipher.Length);

            for (int step = 0; step < steps; step++)
            {
                var messageIndex = step % message.Length;
                var cypherIndex = step % cipher.Length;

                result[messageIndex] =
                    (char)(result[messageIndex] ^ cipher[cypherIndex]);

                // Console.WriteLine(result[messageIndex].ToString());
            }

            return result.ToString(); ;
        }
    }
}
