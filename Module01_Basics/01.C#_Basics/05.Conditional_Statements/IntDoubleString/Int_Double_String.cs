namespace IntDoubleString
{
    using System;

    public class Int_Double_String
    {
        public static void Main()
        {
            string usersChoice = Console.ReadLine();

            switch (usersChoice)
            {
                case "integer":
                    int intNumber = int.Parse(Console.ReadLine());
                    intNumber++;
                    Console.WriteLine(intNumber);
                    break;
                case "real":
                    double doubleNumber = double.Parse(Console.ReadLine());
                    doubleNumber = doubleNumber + 1.0;
                    Console.WriteLine("{0:F2}", doubleNumber);
                    break;
                case "text":
                    string enteredString = Console.ReadLine();
                    enteredString = enteredString + "*";
                    Console.WriteLine(enteredString);
                    break;
            }
        }
    }
}
