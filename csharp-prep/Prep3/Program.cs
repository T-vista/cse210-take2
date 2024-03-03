using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What's your magic number");
        // string num = Console.ReadLine();
        // int magicnum = int.Parse(num); 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (magicNumber != guess)
        {
            Console.WriteLine("what is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            { 
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
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