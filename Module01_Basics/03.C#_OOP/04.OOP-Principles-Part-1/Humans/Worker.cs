namespace Humans
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary 
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The week salary must be positeve.");
                }

                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay 
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Work hours per day cannot be negative or 0.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }
    }
}
