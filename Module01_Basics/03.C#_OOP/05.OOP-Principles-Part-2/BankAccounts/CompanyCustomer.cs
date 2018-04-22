namespace BankAccounts
{
    using System;

    public class CompanyCustomer : Customer
    {
        private string companyName;

        public CompanyCustomer(string address, string phoneNumber, string companyName)
            : base(address, phoneNumber)
        {
            this.CompanyName = companyName;
        }

        public string CompanyName 
        {
            get
            {
                return this.companyName;
            }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentNullException("Company name is too short!");
                }

                this.companyName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Company Customer :\t{0} {1}", CompanyName, base.ToString());
        }
    }
}
