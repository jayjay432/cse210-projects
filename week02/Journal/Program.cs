using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Please select one of the following choices:");

        List<string> menu = new List<string>();
        menu = new List<string>
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };

        // bool isMenu = true;
        Journal journal = new Journal();


        while (true)
        {

            foreach (string i in menu)
            {
                Console.WriteLine(i);
            }

            Console.Write("What would like to do? ");
            string answer = Console.ReadLine();
            int choice = int.Parse(answer);


            if (choice == 1)
            {
                journal.AddEntry();
                Console.Write(journal._entries.Count);

            }
            else if (choice == 2)
            {
                journal.DisplayAllEntries();
            }
            else if (choice == 3)
            {

                journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                journal.SaveToFile();
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("You've entered an invalid choice.");
            }

        }
    }       
}