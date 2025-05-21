using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry()
    {

        // _entries = new List<Entry>();

        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine($"Journal Prompt: {prompt} ");
        string promptAnswer = Console.ReadLine();

        DateTime date = DateTime.Now;

        Entry entry = new Entry(prompt, promptAnswer, date);

        _entries.Add(entry);

    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("----------------------------------------------------");
            entry.Display();
            Console.WriteLine("----------------------------------------------------");
        }
    }

    public void SaveToFile()

    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();

        bool append = File.Exists(fileName);

        using (StreamWriter outputFile = new StreamWriter(fileName, append))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptTest}, {entry._entryTest}");
            }
        }

        Console.WriteLine($"Entries saved to {fileName}.");

    }

    public void LoadFromFile()
    {
        Console.Write("Enter file name to load: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            Console.WriteLine("---- Journal Entries from File ----");

            foreach (string line in lines)
            {
                // Split by comma + space
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);

                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];

                    Console.WriteLine("");

                    Console.WriteLine($"Date: {date}\nPrompts: {prompt}\nEntry text: {response}.");
                    Console.WriteLine("---------------------------------------------------------");

                }
                else
                {
                    Console.WriteLine($"Invalid format: {line}");
                }
            }

            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}