using System;

class SimpleGoal : Goal
{

    private int _targetcount = 1;
    public SimpleGoal(string name, int score) : base(name, score)
    {
        Name = name;
        Score = score;
    }
}