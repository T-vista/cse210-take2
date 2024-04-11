using System;

public class Item
{
    protected string _name;
    protected string _description;
    protected int _goldValue;
    public virtual string GetSaveValue()
    {
        return $"{_name}|{_description}|{_goldValue}";
        //return value;
    }
    public Item(string name, string description, int goldValue)
    {
        _description = description;
        _name = name;
        _goldValue = goldValue;
    }
}