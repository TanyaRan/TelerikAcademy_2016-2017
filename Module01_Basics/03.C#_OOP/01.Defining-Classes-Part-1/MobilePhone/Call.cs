using System;
using System.Text;

namespace MobilePhone
{
    public class Call
    {
        private DateTime callDateTime;
        private string phoneNumber;
        private ulong duration;

        public Call(string phoneNumber, ulong duaration)
        {
            this.CallDateTime = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.Duration = duaration;
        }

        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
            private set
            {
                this.callDateTime = DateTime.Now;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Phone number cannot be null or empty!");
                }
                if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                {
                    throw new ApplicationException("Phonenumber must be in format +359xxxxxxxxx OR 0xxxxxxxxx !");
                }

                this.phoneNumber = value;
            }
        }

        public ulong Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Duaration cannot be a negative number!");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} : Duaration - {1} , made on {2}", this.phoneNumber, this.duration, this.callDateTime);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
