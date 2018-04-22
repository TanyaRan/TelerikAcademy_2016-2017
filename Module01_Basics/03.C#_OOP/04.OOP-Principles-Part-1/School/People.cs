namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class People : ICommentable
    {
         private string name;
         private List<Discipline> allDisciplines;
         private List<string> allComments;

         public People(string name)
         {
             this.Name = name;
             allDisciplines = new List<Discipline>();
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
                     throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols!");
                 }

                 this.name = value;
             }
         }

         public IEnumerable<Discipline> Disciplines 
         {
             get
             {
                 return new List<Discipline>(this.allDisciplines);
             }
         }

         public void AddDiscipline(Discipline newDiscipline)
         {
             this.allDisciplines.Add(newDiscipline);
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
