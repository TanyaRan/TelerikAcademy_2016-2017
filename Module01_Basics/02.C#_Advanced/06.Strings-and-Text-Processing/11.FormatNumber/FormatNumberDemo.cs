﻿using System;

namespace FormatNumber
{
    public class FormatNumberDemo
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
