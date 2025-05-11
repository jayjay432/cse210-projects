using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string userName = PromptUserName();

        int favouriteNumber = PromptUserNumber();
        int square = SquareNumber(favouriteNumber);
        DisplayResult(square, userName);


        static string DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            string greeting = Console.ReadLine();
            return greeting;
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            string answer = Console.ReadLine();
            int favouriteNumber = int.Parse(answer);

            return favouriteNumber;
        }

        static int SquareNumber(int favouriteNumber)
        {
            int square = favouriteNumber * favouriteNumber;
           return  square;
        }

        static void DisplayResult(int square, string userName)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }
}