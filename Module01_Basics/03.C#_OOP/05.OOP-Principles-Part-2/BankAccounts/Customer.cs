namespace BankAccounts
{
    using System;       

    public abstract class Customer
    {        
        private string address;
        private string phoneNumber;

        public Customer(string address, string phoneNumber)
        {            
            this.Address = address;
            this.PhoneNumber = phoneNumber;            
        }
              
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentNullException("Address is too short!");
                }                
                
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value.Length < 5)
                    throw new ArgumentNullException("Phone number is too short!");
                else
                    this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\n\t{3}\t{4}", Address, PhoneNumber);
        }
    }
}
