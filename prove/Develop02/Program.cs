using System;

class Program
{
    static void Main(string[] args)
    {

        string _entry = "0";
        while (_entry != "5")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Create Entry");
            Console.WriteLine("2: Display All Entries");
            Console.WriteLine("3: Save Entry");
            Console.WriteLine("4: Load Entry:");
            Console.WriteLine("5: Quit");
            Console.WriteLine(" ");
            Console.Write("Enter your selection: ");
            _entry = Console.ReadLine();

            if (_entry == "1")
            {
                Journal.AddEntry();
            }
            else if (_entry == "2")
            {
                Journal.DisplayAll();
            }
            else if (_entry == "3")
            {
                Journal.SaveToFile();
            }
            else if (_entry == "4")
            {
                Journal.LoadFromFile();
            }
        }
    }
}