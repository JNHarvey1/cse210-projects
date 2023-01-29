using System;
using System.IO;

public class Journal
{
    public void LoadEntry()
    {
        System.Console.WriteLine("Enter File name: ");
        string fileName = Console.ReadLine();

        string readText = File.ReadAllText(fileName);
        Console.WriteLine(readText);
    }

}