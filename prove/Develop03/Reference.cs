using System;
using System.Data.SqlTypes;

public class Reference
{
    private static string _book;
    private static int _chapter;
    private static int _verse;
    private static int _endVerse = 0;

    public Reference()
    {
        _book = "D&C";
        _chapter = 50;
        _verse = 23;
        _endVerse = 24;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public static string GetDisplayText() 
    {
        string _display;

        if (_endVerse !=  0)
        {
            _display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else 
        {
            _display = $"{_book} {_chapter}:{_verse}";
        }
        return _display;
    }
}