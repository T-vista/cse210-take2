using System;

public class Item
{
    private string _name;
    private string _description;
    private int _goldValue;
    public virtual string GetSaveValue(string name, string description, int goldValue)
    {
        string value = $"{name}|{description}|{goldValue}";
        return value;
    }
    public Item(string name, string description, int goldValue)
    {
        _description = description;
        _name = name;
        _goldValue = goldValue;
    }
}