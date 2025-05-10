using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string  gradePercentage = Console.ReadLine();
        int gradePercentageToInt= int.Parse(gradePercentage);

        int passMark = 70;
        string letterGrade = "";

        if(gradePercentageToInt >= 90)
        {
            letterGrade = "A";
            if(gradePercentageToInt >= passMark)
            {
                Console.WriteLine("Congratulations! You've pass this course.");
            }
            else
            {
                Console.WriteLine("You failed this course.");
            }
            Console.WriteLine($"Your grade is {letterGrade}");
        }

        else if (gradePercentageToInt >= 80)
        {
            letterGrade = "B";
            if(gradePercentageToInt >= passMark)
            {
                Console.WriteLine("Congratulations! You've pass this course.");
            }
            else
            {
                Console.WriteLine("You failed this course.");
            }
            Console.WriteLine($"Your grade is {letterGrade}");
        }

        else if (gradePercentageToInt >=70)
        {
            letterGrade = "C";
            if(gradePercentageToInt >= passMark)
            {
                Console.WriteLine("Congratulations! You've pass this course.");
            }
            else
            {
                Console.WriteLine("You failed this course.");
            }
            Console.WriteLine($"Your grade is {letterGrade}");   
        }

        else if (gradePercentageToInt >= 60)
        {
            letterGrade = "D";
            if(gradePercentageToInt >= passMark)
            {
                Console.WriteLine("Congratulations! You've pass this course.");
            }
            else
            {
                Console.WriteLine("You failed this course.");
            }
            Console.WriteLine($"Your grade is {letterGrade}"); 
        }

        else
        {
            letterGrade = "F";
            if(gradePercentageToInt >= passMark)
            {
                Console.WriteLine("Congratulations! You've pass this course.");
            }
            else
            {
                Console.WriteLine("You failed this course.");
            }
            Console.WriteLine($"Your grade is {letterGrade}");
        }
    }
}