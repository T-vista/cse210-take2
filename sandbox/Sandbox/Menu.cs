using System;

public static class Menu
{
    public static void DisplayMenu()
    {
        string _selection;
        Console.WriteLine($"\nSelect an action:\n1.Roll Dice\n2.Ability Check\n3.Saving Throw\n4.Use Item\n5.Adjust Health\n6.Load Character\n7.Save Character\n8.Quit\n");
        Console.Write("Enter your selection here: ");
        _selection = Console.ReadLine();
    }
}