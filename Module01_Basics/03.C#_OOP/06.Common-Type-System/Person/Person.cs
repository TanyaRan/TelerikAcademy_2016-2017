using System;
using System.Text;
//04.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value). 
//   Override ToString() to display the information of a person and if age is not specified – to say so. 
//   Write a program to test this functionality.

public class Person
{
    private string name;
    private int? age;

    public Person(string name)
        : this(name, null)
    {
    }

    public Person(string name, int? age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value.Length <= 0)
            {
                throw new ArgumentException("Name is too short!");
            }

            this.name = value;
        }
    }

    public int? Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        StringBuilder resultText = new StringBuilder();

        resultText.AppendFormat("Name: {0} \n", this.Name);
        resultText.AppendFormat("Age: {0} \n", this.Age == null ? "Not specified!" : this.Age.ToString());

        return resultText.ToString();
    }
}