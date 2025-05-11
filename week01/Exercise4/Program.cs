using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);

            if (number == 0)
            {
                break;
            }
            else{
                numbers.Add(number);
            }
            
        }

        int lenOfNumbers = numbers.Count;
        int sumOfNumbers = 0;
        double averageNumbers = 0;
        int maximumNumber = 0;
        int minimumNumber = numbers[0];


        foreach (int number in numbers)
        {
            sumOfNumbers += number;
            averageNumbers = (double)sumOfNumbers / lenOfNumbers;

            if (number > maximumNumber)
            {
                maximumNumber = number;
            }

            if (number < minimumNumber )
            {
                if (number > 0 )
                {
                    minimumNumber = number;
                }
            }
            

        }

        numbers.Sort();

            

        Console.WriteLine($"The sum is: {sumOfNumbers}");
        Console.WriteLine($"The average is: {averageNumbers}");
        Console.WriteLine($"The largest number is: {maximumNumber}");
        Console.WriteLine($"The smallest positve number is: {minimumNumber}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}