using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private string _reference = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
    private static List<Word> _words = new List<Word>();

    public Scripture() 
    {
        List<string> _split = _reference.Split(' ').ToList();
        foreach (string i in _split)
        {
            Word w1 = new Word(i, false);
            _words.Add(w1);
        }
    }

    static Random rnd = new Random();
    public static void HideRandomWords()
    {
        int _r = rnd.Next(_words.Count);
        int _r2 = rnd.Next(_words.Count);
        int _r3 = rnd.Next(_words.Count);
        _words[_r].SetIsHidden(true); 
        _words[_r2].SetIsHidden(true); 
        _words[_r3].SetIsHidden(true); 
    }
    public static string GetDisplayText()
    {
        List<string> _text = new List<string>();
        foreach (Word i in _words)
        {
            _text.Add(Word._word);
        }
       string scripture = String.Join(" ", _text);
       return scripture;
    }
    public static bool IsCompletelyHidden()
    {
        bool _yes = true;
        foreach(Word i in _words)
        {
            if (Word._isHidden == false)
            {
                _yes = false;
            }
        }
        return _yes;
    }


}