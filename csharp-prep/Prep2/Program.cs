using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percentage?");
        string gradeString = Console.ReadLine();
        int gradePercent = int.Parse(gradeString);
        string letter = "z";
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! you passed!");
        }
        else
        {
            Console.WriteLine("Oh no! You didn't pass! You'll do better next time!");
        }
        Console.WriteLine(letter);
    }
}