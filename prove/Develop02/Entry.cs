using System;

public class Entry
{
    public static string _date;

    public static string _promptText;

    public static string _enteredText;

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_enteredText);
    }
}    