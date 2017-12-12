using System;
//10.A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name • Last name • Age (0...100) • Gender (m or f)
//•	Personal ID number (e.g. 8306112507) • Unique employee number (27560000…27569999)
//   Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//   Use descriptive names. Print the data at the console.

public class EmployeeData
{
    public static void Main()
    {
        Console.WriteLine("         New Employee :");
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        string employeeFirstName = "Ivan";
        string employeeLastName = "Petkov";
        byte employeeAge = 36;
        char employeeGender = 'm';
        string employeeID = "Manager0303";
        int uniqueNumber = 27560303;
        Console.WriteLine($"Unique employee number - {uniqueNumber}");
        Console.WriteLine($"ID - {employeeID}, Name - {employeeFirstName} {employeeLastName}");
        Console.WriteLine($"Age - {employeeAge} , Gender - {employeeGender}");
    }
}
