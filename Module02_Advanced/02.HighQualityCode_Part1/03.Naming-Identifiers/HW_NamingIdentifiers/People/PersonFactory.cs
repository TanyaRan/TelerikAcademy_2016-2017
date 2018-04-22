namespace People
{
    public class PersonFactory
    {
        public Person MakePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "Ivancho";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Mariyka";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}
