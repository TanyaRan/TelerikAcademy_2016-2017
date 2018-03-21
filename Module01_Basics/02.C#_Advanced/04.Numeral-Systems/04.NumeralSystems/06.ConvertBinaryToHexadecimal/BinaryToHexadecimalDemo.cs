using System;
using System.Text;

namespace ConvertBinaryToHexadecimal
{
    public class BinaryToHexadecimalDemo
    {
        public static void Main()
        {
            string binaryNumber = Console.ReadLine(); 

            string hexNumber = BinaryToHexadecimal(binaryNumber);

            Console.WriteLine(hexNumber);
        }

        private static string BinaryToHexadecimal(string binaryNumber)
        {
            StringBuilder sb = new StringBuilder();
            string tetrada = "";

            while(binaryNumber != "")
            {
                if (binaryNumber.Length <= 4)
                {
                    tetrada = binaryNumber;
                    binaryNumber = "";
                }
                else
                {
                    tetrada = binaryNumber.Substring(binaryNumber.Length - 4);
                    binaryNumber = binaryNumber.Substring(0, binaryNumber.Length - 4);
                }

                switch (tetrada)
                {
                    case "0000":
                        sb.Insert(0, 0);
                        break;
                    case "0001":
                    case "1":
                        sb.Insert(0, 1);
                        break;
                    case "0010":
                    case "10":
                        sb.Insert(0, 2);
                        break;
                    case "0011":
                    case "11":
                        sb.Insert(0, 3);
                        break;
                    case "0100":
                    case "100":
                        sb.Insert(0, 4);
                        break;
                    case "0101":
                    case "101":
                        sb.Insert(0, 5);
                        break;
                    case "0110":
                    case "110":
                        sb.Insert(0, 6);
                        break;
                    case "0111":
                    case "111":
                        sb.Insert(0, 7);
                        break;
                    case "1000":
                        sb.Insert(0, 8);
                        break;
                    case "1001":
                        sb.Insert(0, 9);
                        break;
                    case "1010":
                        sb.Insert(0, 'A');
                        break;
                    case "1011":
                        sb.Insert(0, 'B');
                        break;
                    case "1100":
                        sb.Insert(0, 'C');
                        break;
                    case "1101":
                        sb.Insert(0, 'D');
                        break;
                    case "1110":
                        sb.Insert(0, 'E');
                        break;
                    case "1111":
                        sb.Insert(0, 'F');
                        break;
                }
            }

            return sb.ToString();
        }
    }
}
