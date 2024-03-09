using System;
using System.ComponentModel.DataAnnotations;

public class Journal 
{
    public static List<string> _entries = new List<string>();

    public static void AddEntry()
    {
        string _prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(" ");
        Console.WriteLine(_prompt);
        Console.WriteLine(" ");
        Console.Write("Enter text here: ");
        string _entry = Console.ReadLine();
        Entry._date = DateTime.Now.ToString("M/d/yyyy");
        Entry._promptText = _prompt;
        Entry._enteredText = _entry;
        _entries.Add($"Date: {Entry._date} - Prompt: {Entry._promptText}\n{_entry}");
    }
    public static void DisplayAll()
    {
        foreach (string i in _entries)
        {
            Console.WriteLine(i);
        }
    }
    public static void SaveToFile()
    {
        Console.Write("Enter file name: ");
        string _fileName = Console.ReadLine();
        System.IO.StreamWriter file = new System.IO.StreamWriter($"c:\\{_fileName}.txt");
        foreach (string i in _entries)
        {
            file.WriteLine(i);
        }

        file.Close();
    }
    public static void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string _fileload = Console.ReadLine();
        _entries = File.ReadAllLines($"c:\\{_fileload}.txt").ToList();
    }
}