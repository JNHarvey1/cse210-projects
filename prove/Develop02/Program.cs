using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            System.Console.WriteLine("1) New Entry");
            System.Console.WriteLine("2) Load Entry");
            System.Console.WriteLine("3) Exit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Entry newEntry = new Entry();
                newEntry.CreateEntry();
            }
            if (input == "2")
            {
                Journal newJournal = new Journal();
                newJournal.LoadEntry();
            }
            if (input == "3")
            {
                Environment.Exit(0);
            }
        } while (true);
    }
}