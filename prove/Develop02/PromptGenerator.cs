using System;

public class PromptGenerator
{
    List<string> _prompts = new List<string>{"Who did you meet today?", "What made you the most happy today?", 
    "What was the worst part of today?", "What did you learn today?",
    "What did you get done today that made you the most proud?"};

    public string GetRandomPrompt()
    {
        var random = new Random();
        int _index = random.Next(_prompts.Count); 
        string _prompt = _prompts[_index];
        
        return _prompt;
    }
}    