using System;
//writing assignment
public class WritingAssignment : Assignment 
{
    public WritingAssignment(string name, string topic) : base(name,topic)
    {

    }
    public string GetWritingInformation()
    {
        return $"{GetSummary()} \n The cause of the vietnam war";
    }
}
