using System;

namespace SquareRoot
{
    public class CalculateSquareRoot
    {
        public static void Main()
        {            
            try
            {
                int number;
                bool result = int.TryParse(Console.ReadLine(), out number);

                if (number < 0 || !result)
                {
                    throw new ArgumentException("Invalid number"); 
                }

                double numbersSquareRoot = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", numbersSquareRoot);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
