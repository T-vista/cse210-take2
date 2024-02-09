using System;
using System.Reflection.Metadata.Ecma335;

public class Word
{
    public static string _word;
    public static bool _isHidden;

    public Word(string word, bool hide)
    {
        _word = word;
        _isHidden = hide;
    }
    public static void Hide()
    {
        if (_isHidden == true)
        {
            List<string> _char = _word.Split().ToList();
            List<string> _newChars = new List<string>();
            //int _len =  _word.Length; 
            foreach (string i in _char)
            {
                string _newChar = "_";
                _newChars.Add(_newChar);
            }
             _word = string.Join("",_newChars);
        }
    }

    private void Show()
    {

    }
    public string GetDisplayText(List<string> word)
    {

        string _text = string.Join(" ",word);
        return _text;
    }
    public void SetIsHidden(bool input)
    {
        _isHidden = input;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    
}
