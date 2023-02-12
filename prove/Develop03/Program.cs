using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
        { 
            "Proverbs 3:5-6",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
            "In all thy ways acknowledge him, and he shall direct thy paths."
        };

        Scripture scrip = new Scripture(verses);
        scrip.Display();
        scrip.HideWords(3);
       scrip.IsAllHidden();

        /*
        do
        {
            System.Console.WriteLine("Please press enter to continue, or type 'quit' to exit");
            string input =System.Console.ReadLine();
            if (input == "Enter")
            {
                scrip.HideWords(3);
            }
            else if (input == "quit")
            {
                System.Environment.Exit(1);
            }
        } while (input != "quit");
        */
    }
} 