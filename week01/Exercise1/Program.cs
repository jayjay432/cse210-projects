using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"My name is {lastName}, {firstName} {lastName}.");
    }
}