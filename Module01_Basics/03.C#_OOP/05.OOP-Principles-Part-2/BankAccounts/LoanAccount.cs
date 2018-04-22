﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal interestRate, Customer bankCustomer)
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
                if (numberOfMonths <= 3 && numberOfMonths >= 1)
                    return 0;
                else if (numberOfMonths > 3)
                    return this.InterestRate * (numberOfMonths - 3);
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else if (this.BankCustomer is CompanyCustomer)
            {
                if (numberOfMonths <= 2 && numberOfMonths >= 1)
                    return 0;
                else if (numberOfMonths > 2)
                    return base.InterestRate * (numberOfMonths - 2);
                else
                    throw new ArgumentException("Months must be a positive number");
            }
            else return 0;
        }
    }
}