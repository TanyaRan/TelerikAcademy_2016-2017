namespace DecimalToHex_Variant
{
    using System;
    using System.Linq;
    using System.Text;

    public class DecimalToHexProgram
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (n != 0)
            {
                int toHex = n % 16;

                switch (toHex)
                {
                    case 0:
                        sb.Append(0);
                        break;
                    case 1:
                        sb.Append(1);
                        break;
                    case 2:
                        sb.Append(2);
                        break;
                    case 3:
                        sb.Append(3);
                        break;
                    case 4:
                        sb.Append(4);
                        break;
                    case 5:
                        sb.Append(5);
                        break;
                    case 6:
                        sb.Append(6);
                        break;
                    case 7:
                        sb.Append(7);
                        break;
                    case 8:
                        sb.Append(8);
                        break;
                    case 9:
                        sb.Append(9);
                        break;
                    case 10:
                        sb.Append("A");
                        break;
                    case 11:
                        sb.Append("B");
                        break;
                    case 12:
                        sb.Append("C");
                        break;
                    case 13:
                        sb.Append("D");
                        break;
                    case 14:
                        sb.Append("E");
                        break;
                    case 15:
                        sb.Append("F");
                        break;
                }

                n = n / 16;
            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }

            Console.WriteLine();
        }
    }
}
