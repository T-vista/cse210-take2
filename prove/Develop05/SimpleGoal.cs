using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override void RecordEvent()
    {
        GoalManager.SetScore(Int32.Parse(_points));
        _isComplete = true;
    }
    public override string GetStringRepresentation()
    {
        return $"simplegoal|{_shortname}|{_description}|{_points}|{_isComplete}";
    }
    public override string GetDetailsString()
    {
        string detail = "";
        if (_isComplete == true)
        {
            detail = $"[X] {_shortname} ({_description})";
        }
        else
        {
            detail = $"[ ] {_shortname} ({_description})";
        }
        return detail;
    }
}
