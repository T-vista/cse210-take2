using System;

class Program
{
    static void Main(string[] args)
    {
        Reference nephi = new Reference("1 Nephi", 3, 7);
        bool _end = Scripture.IsCompletelyHidden();

        while (_end == false)
        {
            Console.WriteLine($"{Reference.GetDisplayText()} {Scripture.GetDisplayText()}");
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            Console.ReadLine();
            Console.Clear();
            Scripture.HideRandomWords();
            Word.Hide();
            _end = Scripture.IsCompletelyHidden();
        }
    }
}