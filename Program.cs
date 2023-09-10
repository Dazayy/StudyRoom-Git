
using System;
using System.Diagnostics.Contracts;


class Program
{
    public static void Main(string[] args)
    {
        Person pers = new Person("Sam", 19);
        pers.ShowInfo();
    }
}


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void ShowInfo()
    {
        System.Console.WriteLine($"Name:{Name}\tAge:{Age}");
    }

}

