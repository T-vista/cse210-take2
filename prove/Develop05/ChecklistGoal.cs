using System;

public class ChecklistGoal : Goal
{
    int _amountComplete;
    int _target;
    int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int amount, int bonus) : base(name, description, points)
    {
        _amountComplete = amount;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountComplete ++;
        GoalManager.SetScore(Int32.Parse(_points));
        if (_amountComplete >= _target)
        {
            GoalManager.SetScore(_bonus);
        }
    }
    public override bool IsComplete()
    {
        if (_amountComplete >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string detail = "";
        if (_amountComplete >= _target)
        {
            detail = $"[X] {_shortname} ({_description}) -- Currently complete: {_amountComplete}/{_target}";
        }
        else
        {
            detail = $"[ ] {_shortname} ({_description}) -- Currently complete: {_amountComplete}/{_target}";
        }
        return detail;
    }
    public override string GetStringRepresentation()
    {
        return $"checklistgoal|{_shortname}|{_description}|{_points}|{_target}|{_amountComplete}|{_bonus}";
    }
}