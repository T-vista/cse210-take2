using System;

public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description, int duration) : base(name,description,duration)
    {
    }

    List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else","think of a time you did something really difficult","Think of a time when you helped someone in need","Think of a time when you did something truly selfless"};
    List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done something like this before?","How did you get started","How did you feel when it was complete?","What made this time different from times when you where not successful?","What was your favorite thing about this experience?","What could you learn from this experience that applies to other situations?"};

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_prompts.Count);
        string s = _prompts[r];
        return s;
    }
    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int r = rnd.Next(_questions.Count);
        string s = _questions[r];
        return s;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" -- {GetRandomPrompt()} -- \n");
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience\n");
        Console.WriteLine($"You may begin in...\n");
        ShowCountDown(5);
    }
    public void DisplayQuestion()
    {
        for (int i = _duration/10; i > 0; i--)
        {
            Console.Write($">{GetRandomQuestion()}");
            ShowSpinner(10);
            Console.WriteLine(" ");
        }
        Console.Clear();
    }
    public void Run()
    {
        Console.WriteLine("Get Ready... \n");
        ShowSpinner(5);
        Console.Clear();
        DisplayPrompt();
        Console.Clear();
        DisplayQuestion();


    }
}