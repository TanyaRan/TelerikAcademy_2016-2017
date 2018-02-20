using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivizor
{
    class GreatestCommonDivizorOf2Numbers
    {
        public static void Main()
        {
            var inputNumbers = (Console.ReadLine())
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => int.Parse(x))
                                .ToArray();
            int a = inputNumbers[0];
            int b = inputNumbers[1];

            int GCD;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                GCD = b;
            }
            else
            {
                GCD = a;
            }

            Console.WriteLine(GCD);
        }
    }
}
