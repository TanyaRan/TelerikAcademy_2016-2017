using System;

public class DemoStudent
{
    public static void Main()
    {
        Student stud1 = new Student("Elena", "Ivanova", "Veselinova", "1234123456");
        Console.WriteLine(stud1);

        Student stud2 = new Student("Ina", "Mihova", "Lalova", "9876987655");
        stud2.University = Universities.SofUni;

        Student stud3 = new Student("Ivan", "Ninov", "Nenkov", "1232343453");
        stud3.University = Universities.SofUni;
        stud3.Specialty = UniSpecialties.Biotech;

        Console.WriteLine("stud1 == stud2 -> {0}", stud1 == stud2);
        Console.WriteLine("stud1.Equals(stud2) -> {0}", stud1.Equals(stud2));

        Console.WriteLine("stud1 != stud3 -> {0}", stud1 != stud3);
        Console.WriteLine("stud1.Equals(stud3) -> {0}", stud1.Equals(stud3));

        var cloning = stud3.Clone();
        Console.WriteLine("cloning = stud3.Clone() -> cloning: \n{0}", cloning);

        Console.WriteLine("stud1.CompareTo(stud2) -> {0}", stud1.CompareTo(stud2));
    }
}
