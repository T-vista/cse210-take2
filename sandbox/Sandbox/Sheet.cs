using System;

public static class Sheet
{
    public static void DisplaySheet(Character Char)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------\n" +
        $"Name: {Char.GetName()} Class: {Char.GetClass()} Level: {Char.GetLevel()} \n" +
        $"Race: {Char.GetRace()} Alignment: {Char.GetAlignment()} Experience Points: {Char.GetXP()}\n" +
        "------------------------------------------------------------------------------\n" +
        $"Armor Class: {Char.GetArmorClass()} Speed: {Char.GetSpeed()} Initiative: {Character.FindModifier(Char.GetDEX())}\n" +
        "------------------------------------------------------------------------------\n" +
        $"Saving Throws: STR: {Character.FindModifier(Char.GetSTR())} DEX: {Character.FindModifier(Char.GetDEX())}" +
        $"CON: {Character.FindModifier(Char.GetCON())} INT: {Character.FindModifier(Char.GetINT())}" +
        $"WIS: {Character.FindModifier(Char.GetWIS())} CHA: {Character.FindModifier(Char.GetCHA())}\n\n" +
        "------------------------------------------------------------------------------\n" +
        "Items\n\n" +
        ""+
        "------------------------------------------------------------------------------" 
        );
    }
   

}