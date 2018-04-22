namespace BankAccounts
{
    using System;

    public class IndividualCustomer : Customer
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public IndividualCustomer(string address, string phoneNumber, string firstName, string middleName, string lastName)
            : base(address, phoneNumber)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;                     
        }

      public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentNullException("First name is too short!");
                else
                    this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentNullException("Middle name is too short!");
                else
                    this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentNullException("Last name is too short!");
                else
                    this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Individual Customer :\t{0} {1} {2} {3}", FirstName, 
                      MiddleName, LastName, base.ToString());
        }

    }
}
