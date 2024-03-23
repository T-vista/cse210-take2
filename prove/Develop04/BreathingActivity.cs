using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // dummy variables
        name = "Breathing Activity";
        description = "fart";
        duration = 0;
    }
    // BreathingActivity breath = new BreathingActivity("Breathing Activity","This Activity will help you relax by focusing on your breathing, follow along with the pompts...", 0);
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready... \n");
        ShowSpinner(5);
        for (int i = (_duration + 7)/8;i > 0; i--)
        {
            Console.Write("Breath in...");
            for (int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Console.Write("Breath out...");
            for (int j = 4; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
        }
    }
}
