using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please Enter Your Name:");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please your favorite number:");
            string numString = Console.ReadLine();
            int num = int.Parse(numString);
            return num;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}