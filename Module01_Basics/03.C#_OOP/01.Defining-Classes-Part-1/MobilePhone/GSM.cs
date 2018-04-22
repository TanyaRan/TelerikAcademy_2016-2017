using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    public class GSM
    {
        private static readonly GSM iphone4S =
            new GSM("Iphone 4S", "Apple", 530.00m, "Vivacom",
                new Battery(BatteryType.LiPo, 8, 200),
                new Display(7, 16000000));

        private const decimal callPricePerSecond = 0.002m;

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        private List<Call> CallHistory = new List<Call>();

        public GSM(string model, string manufacturer)
           : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, new Battery(), new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The Model name must be at least 2 characters!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length > 2)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("The Manufacturer name must be more than 2 characters!");
                }
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == null || value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The Price must be a positive number!");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null || value.Length >= 2)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("The Owner name must be at least 2 characters!");
                }
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static GSM IPhone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public void AddCall(string currentPhoneNumber, ulong currentDuaration)
        {
            Call currentCall = new Call(currentPhoneNumber, currentDuaration);
            this.CallHistory.Add(currentCall);
        }

        public void DeleteCall(int position)
        {
            if ((this.CallHistory.Count <= position - 1) || (position - 1 < 0))
            {
                throw new ApplicationException("Such call history log does not exist!");
            }

            this.CallHistory.RemoveAt(position - 1);
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:");
            int indexer = 1;
            foreach (var call in this.CallHistory)
            {
                Console.Write(indexer++);
                Console.Write(" ---> ");
                Console.WriteLine(call.ToString());
            }

            if (CallHistory.Count == 0)
            {
                Console.WriteLine(" ----> No calls!");
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalCallPrice()
        {
            ulong allDurations = 0;
            foreach (var call in this.CallHistory)
            {
                allDurations += call.Duration;
            }

            return allDurations * callPricePerSecond;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GSM device info:");
            sb.AppendLine();
            sb.Append(new string('-', 80));
            sb.AppendFormat("Model: {0},   Manufacturer: {1}", this.Model, this.Manufacturer);
            sb.AppendLine();
            sb.AppendFormat("Price: {0}", this.Price);
            sb.AppendFormat(", Owner: {0}", this.Owner);
            sb.AppendLine();
            sb.Append("GSM Battery Specifications :");
            sb.AppendLine();
            sb.AppendFormat("Type - {0} , talk time - {1} , idle time - {2}", this.Battery.BatteryType, this.Battery.HoursTalk, this.Battery.HoursIdle);
            sb.AppendLine();
            sb.Append("GSM Display Specifications :");
            sb.AppendLine();
            sb.AppendFormat("Size - {0} , Number of Colors - {1}",
                            this.Display.Size, this.Display.NumberOfColors);
            sb.AppendLine();
            sb.AppendLine(new string('*', 80));

            return sb.ToString();
        }
    }
}
