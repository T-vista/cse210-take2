using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity test = new Activity("nuts","eat some nuts fr",12);
        // test.DisplayStartingMessage();
        // test.SetDuration(Console.Read());

        // Activity.ShowSpinner(10);

        // Activity.ShowCountDown(10);
        // BreathingActivity breath = new BreathingActivity("Breathing Activity","This Activity will help you relax by focusing on your breathing, follow along with the pompts...", 0);
        // breath.DisplayStartingMessage();
        // breath.Run();
        ListingActivity list = new ListingActivity("Listing Activity", "In this activity you will create a list of all the things you can think of that satisfy the prompt", 10);
        list.Run();
    }
}