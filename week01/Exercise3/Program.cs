using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("Do you want play? ");
        string response = Console.ReadLine();

        int count = 0;


        while (response == "yes")
        {
            Console.Write("What is the magic number? ");
            string answer = Console.ReadLine();
            int magicNumber = int.Parse(answer);

            while (true)
            {          
                Console.Write("What is your guess? ");
                string guessAnswer = Console.ReadLine();
                int guess = int.Parse(guessAnswer);
                count++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} guesses.");
                    count = 0;
                    break;
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");

    }
}