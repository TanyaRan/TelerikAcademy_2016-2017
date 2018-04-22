namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //Each class has a set of teachers. 
    //Classes have unique text identifier.
    //Students, classes, teachers and disciplines could have optional comments (free text block).

    public class SchoolClass : ICommentable, IUniqueable
    {
        private string uniqueID;
        private List<Teacher> classTeachers;
        private List<string> allComments;

        public SchoolClass(string uniqueID)
        {
            this.UniqueID = uniqueID;
            classTeachers = new List<Teacher>();
            allComments = new List<string>();
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
                    throw new ArgumentNullException("Class name cannot be empty!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Class name cannot be less than 2 symbols!");
                }

                this.uniqueID = value;
            }
        }

        public IEnumerable<Teacher> ClassTeachers
        {
            get
            {
                return new List<Teacher>(this.classTeachers);
            }
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.classTeachers.Add(newTeacher);
        }

        public List<string> Comments
        {
            get
            {
                return new List<string>(this.allComments);
            }
        }

        public void AddComments(string newComment)
        {
            this.allComments.Add(newComment);
        }        
    }
}
