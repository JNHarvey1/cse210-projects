using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topicName, string textbookSection, string problems) : base(studentName, topicName)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return ($"Section: {_textbookSection} Problems: {_problems}");
    }
}