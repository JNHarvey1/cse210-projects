using System;

class Goal
{
    protected string Name;
    protected int Score;
    public virtual void IfComplete() {
        Console.WriteLine($"Goal {0} marked complete! You earned {1} points.", Name, Score);
    }

    public virtual void ShowStatus() {
        Console.WriteLine($"{0}: Not completed", Name);
    }
    Goal(string name, int score)
    {
        Name = name;
        Score = score;
    }
}
