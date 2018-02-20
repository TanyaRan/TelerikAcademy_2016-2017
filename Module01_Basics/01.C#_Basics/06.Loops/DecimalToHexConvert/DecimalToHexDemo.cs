namespace DecimalToHexConvert
{
    using System;
    using System.Text;

    public class DecimalToHexDemo
    {
        public static StringBuilder PositiveDecimalToBinary(int number)
        {
            StringBuilder sb = new StringBuilder();

            if (number != 0)
            {
                sb = sb.Append(0);
                int pos = 30;
                while (pos != -1)
                {
                    if ((number & (1 << pos)) != 0)
                    {
                        sb = sb.Append(1);
                    }
                    else
                    {
                        sb = sb.Append(0);
                    }
                    pos--;
                }
            }

            return sb;
        }

        public static StringBuilder BynaryToHexadecimal(int number)
        {
            StringBuilder binRepresentation = PositiveDecimalToBinary(number);

            StringBuilder hexRepresentation = new StringBuilder();

            for (int index = 0; index < 32; index = index + 4)
            {
                StringBuilder fourDigits = new StringBuilder();

                fourDigits = fourDigits.Append(binRepresentation[index]).
                                        Append(binRepresentation[index + 1]).
                                        Append(binRepresentation[index + 2]).
                                        Append(binRepresentation[index + 3]);
                string tetrada = fourDigits.ToString();

                switch (tetrada)
                {
                    case "0000":
                        hexRepresentation = hexRepresentation.Append(0);
                        break;
                    case "0001":
                        hexRepresentation = hexRepresentation.Append(1);
                        break;
                    case "0010":
                        hexRepresentation = hexRepresentation.Append(2);
                        break;
                    case "0011":
                        hexRepresentation = hexRepresentation.Append(3);
                        break;
                    case "0100":
                        hexRepresentation = hexRepresentation.Append(4);
                        break;
                    case "0101":
                        hexRepresentation = hexRepresentation.Append(5);
                        break;
                    case "0110":
                        hexRepresentation = hexRepresentation.Append(6);
                        break;
                    case "0111":
                        hexRepresentation = hexRepresentation.Append(7);
                        break;
                    case "1000":
                        hexRepresentation = hexRepresentation.Append(8);
                        break;
                    case "1001":
                        hexRepresentation = hexRepresentation.Append(9);
                        break;
                    case "1010":
                        hexRepresentation = hexRepresentation.Append('A');
                        break;
                    case "1011":
                        hexRepresentation = hexRepresentation.Append('B');
                        break;
                    case "1100":
                        hexRepresentation = hexRepresentation.Append('C');
                        break;
                    case "1101":
                        hexRepresentation = hexRepresentation.Append('D');
                        break;
                    case "1110":
                        hexRepresentation = hexRepresentation.Append('E');
                        break;
                    case "1111":
                        hexRepresentation = hexRepresentation.Append('F');
                        break;
                    default:
                        break;
                }
                // Console.WriteLine(fourDigits);
            }

            return hexRepresentation;
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                StringBuilder hexNumber = BynaryToHexadecimal(number);

                Console.WriteLine(hexNumber);
            }
        }
    }
}
