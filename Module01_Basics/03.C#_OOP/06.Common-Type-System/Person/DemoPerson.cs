using System;

public class DemoPerson
{
    public static void Main()
    {
        Person test1 = new Person("Ivan");
        Console.WriteLine(test1);

        Person test2 = new Person("Ivancho", 2);
        Console.WriteLine(test2);

    }
}