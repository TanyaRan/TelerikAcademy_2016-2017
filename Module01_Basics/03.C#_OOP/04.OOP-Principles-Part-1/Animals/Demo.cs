//03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//   Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//   Kittens and tomcats are cats. All animals are described by age, name and sex. 
//   Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
//   Create arrays of different kinds of animals and calculate the average age of each kind of animal 
//   using a static method (you may use LINQ).

namespace Animals
{
    using System;

    public class Demo
    {
        public static void Main()
        {
            Dog sharo = new Dog("Balkan", 12, Sex.Male);
            Console.Write("{0} says - ",sharo.Name);
            sharo.MakeSound();

            Kitten test = new Kitten("Koti", 2, Sex.Female);

            Animal[] myZoo = 
            {
                new Cat("Eli", 2, Sex.Female),
                new Kitten("Beti", 1, Sex.Female),
                new Frog("Gosho", 1, Sex.Male),
                new Frog("Beba", 2, Sex.Female),
                new Dog("Rori", 3, Sex.Male),
                new Cat("Shishka", 5, Sex.Female),
                new Dog("Belka", 4, Sex.Female),
            };

            Animal.AgeAverage(myZoo);
        }
    }
}