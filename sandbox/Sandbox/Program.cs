using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Character test = new Character("Tyler the Gay", "wienner sniffer", "neutral-Good", "dork", "hildabeast", 0, 14,13,10,8,17,12,15,30,1,8 );

        Sheet.DisplaySheet(test);
    }
}