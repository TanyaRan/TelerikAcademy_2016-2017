namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Account : IDepositable
    {
        private decimal balance;
        private decimal interestRate;

        public Account(decimal balance, decimal interestRate, Customer bankCustomer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.BankCustomer = bankCustomer;
        }

        public Customer BankCustomer {  get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative!");
                }
                
                this.interestRate = value;
            }
        }

        public abstract void DepositMoney(decimal deposit);

        public abstract decimal CalculateInterestAmountOfPeriod(int numberOfMonths);
        
    }
}
