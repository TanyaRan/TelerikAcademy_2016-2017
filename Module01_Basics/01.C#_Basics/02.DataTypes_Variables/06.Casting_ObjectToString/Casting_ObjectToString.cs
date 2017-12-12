using System;
//06.Declare two string variables and assign them with 
//   “Hello” and “World”. Declare an object variable and assign it 
//   with the concatenation of the first two variables 
//   (mind adding an interval between). Declare a third string variable and 
//   initialize it with the value of the object variable 
//   (you should perform type casting).

public class Casting_ObjectToString
{
    public static void Main()
    {
        string helloWord = "Hello";
        string worldWord = "World";

        object sayHelloObject = helloWord + " " + worldWord;
        string sayHelloString = (string)sayHelloObject;
        sayHelloString = sayHelloString + "!";

        Console.WriteLine(sayHelloString);
    }
}
