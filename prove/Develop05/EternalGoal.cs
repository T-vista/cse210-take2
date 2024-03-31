using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent()
    {
        GoalManager.SetScore(Int32.Parse(_points));
    }
    public override string GetDetailsString()
    {
        string detail = $"[ ] {_shortname} ({_description})";
        return detail;
    }
    // for saving the file
    public override string GetStringRepresentation()
    {
        return $"eternalgoal|{_shortname}|{_description}|{_points}";
    }
}