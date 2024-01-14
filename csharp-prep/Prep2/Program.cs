using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string number = Console.ReadLine();
        int percentage = int.Parse(number);

        string grade = " ";
        bool pass = false ;

        if (percentage >= 90)
        {
            grade = "A";
            pass = true;
        }
        else if (percentage >= 80)
        {
            grade = "B";
            pass = true;
        }
        else if (percentage >= 70)
        {
            grade = "C";
            pass = true;
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (pass == true)
        {
            Console.WriteLine("Congradulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, you did not pass");
        }
    }
}