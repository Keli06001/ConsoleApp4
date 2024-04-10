using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get { return FirstName + " " + LastName; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.FirstName = "John";
        person.LastName = "Doe";

        Console.WriteLine("Full Name: " + person.FullName);
    }
}
