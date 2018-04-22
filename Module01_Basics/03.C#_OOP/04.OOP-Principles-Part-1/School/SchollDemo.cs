namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    //01.We are given a school. In the school there are classes of students. Each class has a set of teachers. 
    //   Each teacher teaches a set of disciplines. Students have name and unique class number. 
    //   Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
    //   Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).

    //   Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
    //   define the class hierarchy and create a class diagram with Visual Studio.
    public class SchollDemo
    {
        static void Main()
        {
            Teacher aIv = new Teacher("Anna Ivanova");
            Teacher mKo = new Teacher("Mila Koleva");
            aIv.AddComments("Nachalna Pedagogika, Sofiyski Univ");
            mKo.AddComments("Matematika i Nachalna Pedagogika, Plovdiv Univ");

            SchoolClass class1a = new SchoolClass("1a");
            SchoolClass class2a = new SchoolClass("2a");

            Discipline lit = new Discipline("Literature", 26, 26);
            Discipline mat = new Discipline("Math", 26, 13);
            Discipline mus = new Discipline("Music", 13, 13);
            Discipline his = new Discipline("History", 26, 13);

            class1a.AddTeacher(aIv);
            class1a.AddTeacher(mKo);
            aIv.AddDiscipline(lit);
            aIv.AddDiscipline(his);

            class2a.AddTeacher(mKo);
            mKo.AddDiscipline(mat);
            mKo.AddDiscipline(mus);

            Console.WriteLine("Na 1a klas prepodavat : {0} i {1}",
                aIv.Name, mKo.Name);            
        }
    }
}
