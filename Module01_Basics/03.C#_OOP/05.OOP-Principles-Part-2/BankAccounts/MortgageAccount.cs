using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal interestRate, Customer bankCustomer)
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

        public override decimal CalculateInterestAmountOfPeriod(int numberOfMonths)
        {
            if (this.BankCustomer is IndividualCustomer)
            {
                if (numberOfMonths <= 6 && numberOfMonths >= 0)
                    return 0;
                else if (numberOfMonths > 6)
                    return base.InterestRate * numberOfMonths;
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else if (this.BankCustomer is CompanyCustomer)
            {
                if (numberOfMonths <= 12 && numberOfMonths >= 0)
                    return (decimal)(base.InterestRate / 2 * numberOfMonths);
                else if (numberOfMonths > 12)
                    return base.InterestRate * numberOfMonths;
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else return 0;
        }
    }
}
