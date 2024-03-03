using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int newNumber = SquareNumber(userNumber);
        DisplayResult(userName, newNumber);
    }    
    static void DisplayWelcome()
    {
        //welcome message
        Console.WriteLine("Welcome to the program! Follow the prompts!");
    }
    static string PromptUserName()
    {
        //ask for user name
        Console.Write("Please enter your name: ");
        string _name = Console.ReadLine();
        return _name;
    }
    static int PromptUserNumber()
    {
        // get a number from the user
        Console.Write("Please enter your favorite number: ");
        int _number = int.Parse(Console.ReadLine());
        return _number;
    }
    static int SquareNumber(int num1)
    {
        //square the number and return result
        int _squaredNumber = num1 * num1;
        return _squaredNumber;
    }
    static void DisplayResult(string name, int number)
    {
        //print the result of the exercise
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}