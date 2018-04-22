using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class DepositAccount : Account, IWithDrawable
    {
        public DepositAccount(decimal balance, decimal interestRate, Customer bankCustomer)
            : base(balance, interestRate, bankCustomer)
        {
        }

        public override void DepositMoney(decimal deposit)
        {
            if (deposit <= 0)
            {
                throw new ArgumentException("Deposit sum must be positive!");
            }
            
            this.Balance += deposit;
        }

        public override void WithDrawMoney(decimal withDrawSum)
        {
            if (withDrawSum <= 0)
            {
                throw new ArgumentException("With draw sum must be positive!");
            }

            this.Balance -= withDrawSum;
        }

        public override decimal CalculateInterestAmountOfPeriod(int numberOfMonths)
        {
            if (this.Balance <= 1000 && this.Balance >= 0)
                return 0;
            else if (this.Balance > 1000)
                return this.InterestRate * numberOfMonths;            
        }
    }
}
