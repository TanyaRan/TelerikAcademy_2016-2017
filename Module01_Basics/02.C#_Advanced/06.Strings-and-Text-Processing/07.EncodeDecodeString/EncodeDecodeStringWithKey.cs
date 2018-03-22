using System;
using System.Text;

namespace EncodeDecodeString
{
    public class EncodeDecodeStringWithKey
    {
        public static void Main()
        {
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
            StringBuilder codedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                char codedSymbol = (char)(message[i] ^ cipher[i % cipher.Length]);
                
                codedMessage.Append(codedSymbol);
            }

            return codedMessage.ToString();
        }
    }
}
