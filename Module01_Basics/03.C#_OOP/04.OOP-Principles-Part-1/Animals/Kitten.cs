namespace Animals
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, Sex sex)
            : base(name, age)
        {
            if (sex == Sex.Male)
            {
                throw new ArgumentException("Wrong sex !");
            }

            this.Sex = sex;
        }
    }
}