namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //Disciplines have name, number of lectures and number of exercises. 
    //Students, classes, teachers and disciplines could have optional comments (free text block).

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private List<string> allComments;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            allComments = new List<string>();
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Discipline Name is too short.");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures 
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative or 0.");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be negative or 0.");
                }

                this.numberOfExercises = value;
            }
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
