using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your magic number");
        // string num = Console.ReadLine();
        // int magicnum = int.Parse(num); 
        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 101);
        int guess = -1;

        while (magicnum != guess)
        {
            Console.WriteLine("what is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (magicnum > guess)
            { 
                Console.WriteLine("Higher");
            }
            else if (magicnum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}