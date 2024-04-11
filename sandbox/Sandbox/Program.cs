using System;

class Program
{
    static void Main(string[] args)
    {
        Character test = new Character("Tyler the Grey", "Wizard", "neutral-Good", "orc", "hildabeast", 0, 14,13,10,8,17,12,15,30,1,8 );

        Sheet.DisplaySheet(test);
        Menu.DisplayMenu();
    }
}