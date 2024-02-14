using System;

class Program
{
    static void Main(string[] args)
    {
        Activity test = new Activity("nuts","eat some nuts fr",12);
        test.DisplayStartingMessage();
        test.SetDuration(Console.Read());
    }
}