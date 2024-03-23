using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math = new Assignment("tyler", "math");
        Console.WriteLine(math.GetSummary());

        MathAssignment math2 = new MathAssignment("Jose", "Math");
        Console.WriteLine(math2.GetSummary());
        Console.WriteLine(math2.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Sally", "english");
        Console.WriteLine(write.GetWritingInformation());
    
        
    }
}