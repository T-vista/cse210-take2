using System;
using System.Data;

public class Character
{
    string _class;
    string _alignment;
    string _race;
    string _background;
    int _XP;
    int _hitDice;
    public Character(string name, string Class, string alignment, string race, string background, int xpPoints, int str, int dex, int con, int INT, int wis, int cha, int AC, int speed, int level, int hitDice)
    {
        _class = Class;
        _alignment = alignment;
        _name = name;
        _race = race;
        _background = background;
        _XP = xpPoints;
        _str = str;
        _dex = dex;
        _con = con;
        _int = INT;
        _wis = wis;
        _cha = cha;
        _armorClass = AC;
        _speed = speed;
        _level = level;
        _hitDice = hitDice;
    }
    private int _maxHealthPoints;
    public int GetMaxHP()
   {
       return _maxHealthPoints;
   }
   public void SetMaxHP(int value)
   {
       _maxHealthPoints = value;
   }

   private int _currentHealthPoints;
    public int GetCurrentHP()
   {
       return _currentHealthPoints;
   }
   public void SetCurrentHP(int value)
   {
       _currentHealthPoints = value;
   }

   private int _level;
    public int GetLevel()
   {
       return _level;
   }
   public void SetLevel(int value)
   {
       _level = value;
   }

   private int _str;
    public int GetSTR()
   {
       return _str;
   }
   public void SetSTR(int value)
   {
       _str = value;
   }

   private int _con;
    public int GetCON()
   {
       return _con;
   }
   public void SetCON(int value)
   {
       _con = value;
   }

   private int _dex;
    public int GetDEX()
   {
       return _dex;
   }
   public void SetDEX(int value)
   {
       _dex = value;
   }

   private int _int;
    public int GetINT()
   {
       return _int;
   }
   public void SetINT(int value)
   {
       _int = value;
   }

   private int _wis;
    public int GetWIS()
   {
       return _wis;
   }
   public void SetWIS(int value)
   {
       _wis = value;
   }

   private int _cha;
    public int GetCHA()
   {
       return _cha;
   }
   public void SetCha(int value)
   {
       _cha = value;
   }

//in charachter
   private int _armorClass;
    public int GetArmorClass()
   {
       return _armorClass;
   }
   public void SetArmorClass(int value)
   {
       _armorClass = value;
   }

// in charachter
   private int _initiative;
    public int Getinitiative()
   {
       return _initiative;
   }
   public void Setinitiative(int value)
   {
       _initiative = value;
   }

// could go in charachter
   private int _speed;
    public int GetSpeed()
   {
       return _speed;
   }
    public void SetSpeed(int value)
   {
       _speed = value;
   }

   private int _gold;
    public int GetGold()
   {
       return _gold;
   }
   public void SetGold(int value)
   {
       _gold = value;
   }

// done by level so could go in charachter
   private int _proficiencyBonus;
    public int GetProficiencyBonus()
   {
       return _proficiencyBonus;
   }
   public void SetProficiencyBonus(int value)
   {
       _proficiencyBonus = value;
   }

   private string _name;

   public void SetName(string value)
   {
    _name = value;
   }
   public string GetName()
   {
    return _name;
   }
    public string GetClass()
   {
    return _class;
   }
    public string GetRace()
   {
    return _race;
   }
    public string GetAlignment()
   {
    return _alignment;
   }
    public int GetXP()
   {
    return _XP;
   }

   public static int FindModifier(int value)
    {
        int solution = (value - 10) / 2;
        return solution;
    }




}