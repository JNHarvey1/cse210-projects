using System;

class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topicName)
    {
        _studentName = studentName;
        _topic = topicName;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}