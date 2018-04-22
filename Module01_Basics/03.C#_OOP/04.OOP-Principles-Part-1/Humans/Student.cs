namespace Humans
{
    using System;
    
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The grade must be positive.");
                }

                this.grade = value;
            }
        }
    }
}
