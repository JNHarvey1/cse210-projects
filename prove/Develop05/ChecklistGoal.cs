using System;

class ChecklistGoal : Goal
{
    public int _count;
    private int _targetCount;
    private int _bonusScore;

    public ChecklistGoal(string name, int score, int targetCount, int bonusScore) : base(name, score)
    {
        _count = 0;
        _targetCount = targetCount;
        _bonusScore = bonusScore;
    }

    public void RecordEvent()
    {
        _count++;
        int totalScore = _count * Score;
        if (_count == _targetCount)
        {
            totalScore += _bonusScore;
            System.Console.WriteLine($"Congratulations! You finished the {Name} goal {totalScore} times and gained {totalScore} points! Plus a bonus of {_bonusScore} points!");
        }
        else
        {
            System.Console.WriteLine($"Congratulations! You finished the {Name} goal {_count}/{_targetCount} times and gained {totalScore} points!");
        }
        }
}