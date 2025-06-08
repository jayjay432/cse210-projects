using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words each time
        }
    }
}