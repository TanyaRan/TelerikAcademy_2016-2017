namespace Humans
{
    using System;
  
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
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
                {
                    throw new ArgumentException("The name cannot be less than 2 symbols.");
                }

                this.firstName = value;
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
                {
                    throw new ArgumentException("The name cannot be less than 2 symbols.");
                }

                this.lastName = value;
            }
        }        
    }
}
