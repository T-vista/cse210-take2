using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public void SetDuration(int dur)
    {
        _duration = dur;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} \n\n{_description} \n\nHow long in seconds would you like to do this activity?");
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }
}