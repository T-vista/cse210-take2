using System;
using System.ComponentModel.DataAnnotations;

public class Journal 
{
    List<string> _entries = new List<string>();

    void AddEntry()
    {
        Console.WriteLine("Enter text here");
        string _entry = Console.ReadLine();
        _entries.Add(_entry);
    }
    void DisplayAll()
    {
        foreach (string i in _entries)
        {
            Console.WriteLine(i);
        }
    }
    void SaveToFile()
    {
        Console.WriteLine("Enter file name");
        string _filename = Console.ReadLine();
        System.IO.StreamWriter file = new System.IO.StreamWriter($"c:\\{_filename}.txt");
        foreach (string i in _entries)
        {
            file.WriteLine(i);
        }

        file.Close();
    }
    void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string _fileload = Console.ReadLine();
        File.ReadLines($"c;\\{_fileload}.txt");
    }
}