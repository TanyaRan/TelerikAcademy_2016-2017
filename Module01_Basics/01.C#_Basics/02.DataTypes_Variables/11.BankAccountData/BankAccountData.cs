using System;
//11.A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//   bank name, IBAN, 3 credit card numbers associated with the account. 
//   Declare the variables needed to keep the information for a single bank account using the appropriate 
//   data types and descriptive names.

public class BankAccountData
{
    public static void Main()
    {
        Console.WriteLine("   Bank Accout - SIBANK EAD :");
        Console.WriteLine("- - - - - - - - - - - - - - - -");

        string customerFirstName = "Ivan";
        string customerMiddleName = "Petrov";
        string customerLastName = "Ivanov";
        Console.WriteLine($"Customer : {customerFirstName} {customerMiddleName} {customerLastName}");

        string bankName = "SIBANK EAD";
        string codeBIC = "BUIBBGSF";
        //Bank Identifier Code (BIC) is unique identification code

        string customerIBAN = "BG11-STSA9300-11-12345678";
        //International Bank Account Number - IBAN

        Console.WriteLine($"Bank Name : {bankName}");
        Console.WriteLine($"BIC : {codeBIC} ,  IBAN : {customerIBAN}");

        string cardVisa = "4000-1234-1234-1234";
        Console.WriteLine($"Visa Card : {cardVisa}");
        string cardAmericanExpress = "3111-654321-54321";
        Console.WriteLine($"American Express Card : {cardAmericanExpress}");
        string cardMasterCard = "5222-4444-5555-6666";
        Console.WriteLine($"Master Card : {cardMasterCard}");

        decimal customerBalance = 1035;
        Console.WriteLine($"Customer Balance : $ {customerBalance}");
        Console.WriteLine($"Date : {DateTime.Now}");
    }
}
