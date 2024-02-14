using System;

public class MathAssignment : Assignment
{
    public MathAssignment(string name, string topic) : base(name, topic)
    {
    }

    public string GetHomeworkList()
    {
        return  "assignment1, assignment2 ";
    }
}

