using System;

public class GravitationOnTheMoon
{
    public static void Main()
    {
        float earthWeight = float.Parse(Console.ReadLine());

        float moonWeight = earthWeight * 17 / 100;
        Console.WriteLine("{0:f3}", moonWeight);
    }
}