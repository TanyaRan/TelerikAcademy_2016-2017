using System;

namespace MobilePhone
{
    public class Display
    {
        private const double MAX_PHONE_SIZE = 8;
        private const double MIN_PHONE_SIZE = 3.5;
        private const int MAX_NUMBER_OF_COLORS = int.MaxValue;
        private const int MIN_NUMBER_OF_COLORS = 65536;

        private double size;
        private int? numberOfColors;

        public Display()
        {
        }

        public Display(double size)
            : this(size, null)
        {
        }

        public Display(double size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value > MAX_PHONE_SIZE)
                {
                    throw new ArgumentException("Phone size can not be such a large number!");
                }

                if (value < MIN_PHONE_SIZE)
                {
                    throw new ArgumentException("Phone size can not be such a small number!");
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                if (value > MAX_NUMBER_OF_COLORS)
                {
                    throw new ArgumentException("Phone number of colors can not be such a large number!");
                }

                if (value < MIN_NUMBER_OF_COLORS)
                {
                    throw new ArgumentException("Phone number of colors can not be such a small number!");
                }

                this.numberOfColors = value;
            }
        }
    }
}
