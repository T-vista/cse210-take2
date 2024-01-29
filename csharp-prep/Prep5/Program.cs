using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string _userName = PromptUserName();
        int _userNumber = PromptUserNumber();

        int _newNumber = SquareNumber(_userNumber);
        DisplayResult(_userName, _newNumber);
    }    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string _name = Console.ReadLine();
        return _name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int _number = int.Parse(Console.ReadLine());
        return _number;
    }
    static int SquareNumber(int num1)
    {
        int _squaredNumber = num1 * num1;
        return _squaredNumber;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}