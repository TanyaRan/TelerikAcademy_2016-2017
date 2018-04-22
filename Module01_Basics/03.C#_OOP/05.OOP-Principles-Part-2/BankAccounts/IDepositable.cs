namespace BankAccounts
{
    using System;
    
    public interface IDepositable
    {
        void DepositMoney(decimal deposit);

        decimal CalculateInterestAmountOfPeriod(int numberOfMonths);
    }
}
