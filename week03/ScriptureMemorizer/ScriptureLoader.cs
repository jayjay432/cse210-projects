

public class ScriptureLoader
{
    public static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Scripture file not found!");
            return scriptures;
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            // Skip empty lines
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length < 4)
            {
                Console.WriteLine($"Invalid line format: {line}");
                continue;
            }

            string book = parts[0];
            if (!int.TryParse(parts[1], out int chapter))
            {
                Console.WriteLine($"Invalid chapter in line: {line}");
                continue;
            }
            if (!int.TryParse(parts[2], out int verse))
            {
                Console.WriteLine($"Invalid verse in line: {line}");
                continue;
            }

            string text = parts[3];

            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, text);
            scriptures.Add(scripture);
        }

        return scriptures;
    }
}
