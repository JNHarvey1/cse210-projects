using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topicName, string title) : base(studentName, topicName)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = _studentName;
        return ($"Title: {_title} by {studentName}");
    }
}