using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity("Breathing Activity","This Activity will help you relax by focusing on your breathing, follow along with the pompts...", 0);
        ListingActivity list = new ListingActivity("Listing Activity", "In this activity you will create a list of all the things you can think of that satisfy the prompt", 10);
        ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on your acomplishments and focus on your successes", 30);

        string choice = "0";
        while (choice!= "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options\n1. Start Breathing Activity\n2. Start Listing Activity\n3. Start Reflecting Activity\n4. Quit\nSelect a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                breath.DisplayStartingMessage();
                breath.Run();
                breath.DisplayEndingMessage();
                breath.ShowSpinner(5);
            }
            else if (choice == "2")
            {
                Console.Clear();
                list.DisplayStartingMessage();
                list.Run();
                list.DisplayEndingMessage();
                list.ShowSpinner(5);
            }
            else if (choice == "3")
            {
                Console.Clear();
                reflect.DisplayStartingMessage();
                reflect.Run();
                reflect.DisplayEndingMessage();
                reflect.ShowSpinner(5);
            }
            else 
            {
            }
        }
    }
}