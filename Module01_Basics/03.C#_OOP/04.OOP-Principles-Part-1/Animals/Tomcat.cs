namespace Animals
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age, Sex sex)
            : base(name, age)
        {
            if (sex == Sex.Female)
            {
                throw new ArgumentException("Wrong sex !");
            }

            this.Sex = sex;
        }
    }
}