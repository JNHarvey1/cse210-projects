using System;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;
    static void Main(string[] args)
    {
        LoadGoals();
        do
        {
            Console.WriteLine();
            Console.WriteLine("Input a number to make a selection.");
            Console.WriteLine("1. List goals");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record completion");
            Console.WriteLine("4. Save goals and score");
            Console.WriteLine("5. Load goals and score");
            Console.WriteLine("6. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                ListGoals();
            }
            if (input == "2")
            {
                CreateGoal();
            }
            if (input == "3")
            {
                RecordEvent();
            }
            if (input == "4")
            {
                SaveGoals();
            }
            if (input == "5")
            {
                LoadGoals();
            }
            if (input == "6")
            {
                Environment.Exit(0);
            }
        }
        }



      static void LoadGoals() {
        if (!File.Exists("Goals.txt")) {
            return;
        }

        string[] lines = File.ReadAllLines("Goals.txt");

        foreach (string line in lines) {
            string[] parts = line.Split(',');
            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);
            int targetCount = int.Parse(parts[3]);

            Goal goal;

            if (type == "SimpleGoal") {
                goal = new SimpleGoal(name, points);
            }
            else if (type == "EternalGoal") {
                goal = new EternalGoal(name, points);
            }
            else if (type == "ChecklistGoal") {
                goal = new ChecklistGoal(name, points, targetCount, 50);
            }
        }
      }

    static void ListGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklist = (ChecklistGoal)goal;
                Console.WriteLine($"{checklist.Name} completed {checklist._count} times, target {checklist.bonusScore}");
            }
        }
    }


}