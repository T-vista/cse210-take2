using System;
using System.Data;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration) : base(name,description,duration)
    {
    } 
    private int _count;
    List<string> _prompts = new List<string>{"Who are people you appreciate?", "Who are people you have helped this week?", "When have you felt the Holy Ghost this month", "Who are some of your personal heros?"};
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int r = rand.Next(_prompts.Count);
        string s = _prompts[r];
        return s;
    }
    public List<string> GetListFromUser(int time)
    {
        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(time);

        List<string> _list =new List<string>();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(time);
        while (currentTime < futureTime)
        {
            Console.Write(">");
            _list.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        return _list;
    }
    public void Run()
    {
        Console.WriteLine("Get ready...");
        base.ShowSpinner(5);
        Console.Clear();
        Console.WriteLine($"\nList as many responses as you can to the following prompt \n\n--{GetRandomPrompt()}-- \n\nBegin in");
        ShowCountDown(10);
        Console.Clear();
        _count = GetListFromUser(_duration).Count;
        Console.WriteLine($"\nGreat job! you listed {_count} items!");

    }

}