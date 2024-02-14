using System;

public class Assignment
{
    protected static string _studentName;
    protected static string _topic;

    public string GetSummary()
    {
        string nuts = $"Name: {_studentName} Topic: {_topic}";
        return nuts;
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
}