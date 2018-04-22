namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //Students have name and unique class number.
    //Both teachers and students are people. 
    //Students, classes, teachers and disciplines could have optional comments (free text block).

    public class Student : People, ICommentable, IUniqueable
    {
        private string uniqueID;

        public Student(string name)
            : base(name)
        {           
        }

        public Student(string name, string uniqueID)
            : this(name)
        {
            this.UniqueID = uniqueID;
            List<string> AllComments = new List<string>();
        }

        public string UniqueID
        {
            get
            {
                return this.uniqueID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID cannot be empty!");
                }

                this.uniqueID = value;
            }
        }
    }
}
