using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
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
        SetDuration(Convert.ToInt32(Console.ReadLine()));
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! you have completed {_duration} seconds of the {_name}!");
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(334);
            Console.Write("\b \b");
        }
    }
    public static void ShowCountDown(int seconds)
    {
        for (int i=seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
        }
    }
}