using System;

namespace People
{
    public class StartupPeople
    {
        public static void Main()
        {
            PersonFactory factory = new PersonFactory();
            var ivancho = factory.MakePerson(12);

            Console.WriteLine($"{ivancho.Name} {ivancho.Age} {ivancho.Gender}");
        }
    }
}
