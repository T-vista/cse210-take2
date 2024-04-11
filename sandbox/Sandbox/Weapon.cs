using System;
using System.Collections.Specialized;

public class Weapon : Item
{
    string _damageType;
    int _damageDie;
    public Weapon(string name, string description, int goldValue, string damageType, int damageDie) : base(name, description, goldValue)
    {
        _damageDie = damageDie;
        _damageType = damageType;
    }
    public override string GetSaveValue()
    {
        return $"{_name}|{_description}|{_goldValue}|{_damageType}|{_damageDie}";
    }
}