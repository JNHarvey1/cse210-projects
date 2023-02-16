using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("Samuel Bennett", "Multiplication");
        assign.GetSummary();

               
        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());

        WritingAssignment writeAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeAssign.GetSummary());
        Console.WriteLine(writeAssign.GetWritingInformation());

    }
}