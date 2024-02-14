using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment math = new Assignment("tyler", "math");
        Console.WriteLine(math.GetSummary());

        MathAssignment math1 = new MathAssignment("Jose", "Math");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Sally", "english");
        Console.WriteLine(write.GetWritingInformation());
    
        
    }
}