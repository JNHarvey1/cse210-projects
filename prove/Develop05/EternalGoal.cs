using System;

class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string name, int score) : base(name, score)
    {
        _count = 0;
    }

    public void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Congratulations! You completed the {Name} goal {_count} times and gained {Score} points.");
    }
}