using System;

public class CompanyInfo
{
    public static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        if (string.IsNullOrEmpty(faxNumber))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", faxNumber);
        }
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}