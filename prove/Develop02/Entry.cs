using System;
using System.IO;

public class Entry
{
    public void CreateEntry()
    {
        string[] prompts = 
        {
            "What could you have done better today?",
            "What was the best thing that happened today?",
            "What are you looking forward to?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Length);

        System.Console.WriteLine($"{prompts[index]}");
        System.Console.WriteLine(">");
        string journalEntry = System.Console.ReadLine();

        string date = DateTime.Now.ToString("MM/dd/yyyy");

        System.Console.WriteLine($"Prompt:{prompts[index]} Entry: {journalEntry}");

        Console.Write("Please name this entry (with .txt): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Date: {date} Prompt:{prompts[index]} Entry: {journalEntry}");
        } 
    }

}