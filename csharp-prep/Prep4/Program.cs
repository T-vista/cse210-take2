using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //print('enter a list of numbers, typ)
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers;
        numbers = new List<int>();
        
        int number = 1;
        while (number != 0)
        {
            Console.WriteLine("Enter a number");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;

        foreach (int i in numbers )
        {
            sum = i + sum;
        }

        Console.WriteLine($"Sum: {sum}");

        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"Average: {avg}");

        int maximum = 0;

        foreach (int i in numbers)
        {
            if (i > maximum)
            {
                maximum = i;
            }
        }

        Console.WriteLine($"The largest number is: {maximum}");
        

    }
}