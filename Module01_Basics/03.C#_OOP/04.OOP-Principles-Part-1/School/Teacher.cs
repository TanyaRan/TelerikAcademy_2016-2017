namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //Each teacher teaches a set of disciplines.
    //Teachers have name.
    //Both teachers and students are people. 
    //Students, classes, teachers and disciplines could have optional comments (free text block).

    public class Teacher : People, ICommentable
    {
        public Teacher(string name)
            : base(name)
        {            
            List<Discipline> AllDisciplines = new List<Discipline>();
            List<string> AllComments = new List<string>();
        }        
    }
}
