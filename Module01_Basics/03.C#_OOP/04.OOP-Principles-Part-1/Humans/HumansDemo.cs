//02.Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
//   and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
//   and method MoneyPerHour() that returns money earned by hour by the worker. 
//   Define the proper constructors and properties for this hierarchy. 
//   Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//   Initialize a list of 10 workers and sort them by money per hour in descending order. 
//   Merge the lists and sort them by first name and last name.

namespace Humans
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
        
    public class HumansDemo
    {
        static void Main()
        {
            Student[] groupOfStudents = 
            {
                new Student("Ivanka", "Ivanova", 2),
                new Student("Penka", "Todorova", 4),
                new Student("Ico", "Penev", 3),
                new Student("Galya", "Getova", 6),
                new Student("Stoian", "Stoianov", 5),
                new Student("Kosta", "Kolev", 3),
                new Student("Dani", "Antova", 6),
                new Student("Hana", "Bobeva", 4),
                new Student("Lina", "Bratoeva", 5),
                new Student("Asen", "Ivanov", 6),
            };

            Worker[] groupOfWorkers = 
            {
                new Worker("Biser", "Ivanov", 500, 8),
                new Worker("Teodor", "Teodorov", 500, 4),
                new Worker("Ivan", "Petev", 600, 6),
                new Worker("Gosho", "Liskov", 700, 8),
                new Worker("Sisi", "Kalinova", 400, 8),
                new Worker("Kiril", "Ognyanov", 900, 8),
                new Worker("Boris", "Draganov", 100, 2),
                new Worker("Monika", "Misheva", 350, 6),
                new Worker("Hrisi", "Velkova", 600, 6),
                new Worker("Ani", "Ivanova", 700, 8),
            };
            
            //sort Students by grade in ascending order
            var sortedStudents = groupOfStudents.OrderBy(x => x.Grade);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine("--------------------------------------------");

            //sort Workers by money per hour in descending order
            var sortedWorkers = groupOfWorkers.OrderByDescending(x => x.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1} {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("--------------------------------------------");

            List<Human> mergedHumans = new List<Human>();

            mergedHumans.AddRange(sortedStudents.ToList());
            mergedHumans.AddRange(sortedWorkers.ToList());

            foreach (var human in mergedHumans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }

            Console.WriteLine("--------------------------------------------");

            //sort Humans by first name and last name
            var sortedByNames = mergedHumans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var human in sortedByNames)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
