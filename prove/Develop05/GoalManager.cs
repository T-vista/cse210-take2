using System.IO;
using System.Formats.Asn1;
using System.Runtime.Serialization;

public static class GoalManager
{
    public static List<Goal> _goals = new List<Goal>();
    private static int _score;
    public static void SetScore(int num)
    {
        _score = _score + num;
    }
    public static void Start()
    {
        string option = "0";
        while (option != "6")
        {
            Console.WriteLine($"\nScore: {_score}\n");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Goal\n6. Quit\n");
            Console.WriteLine("Select an option from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine(" ");
            if (option == "1")
            {
                CreateGoal();
            }
            else if (option == "2")
            {
                ListGoalDetails();
            }
            else if (option == "3")
            {
                SaveGoals();
            }
            else if (option == "4")
            {
                LoadGoals();
            }
            else if (option == "5")
            {
                RecordGoal();
            }
            else if (option == "6")
            {

            }
            else
            {
                Console.WriteLine($"\nSorry that is not a valid response, please try again");
                Thread.Sleep(3000);
            }
        }
    }

    public static void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent score:{_score}\n");
    }
    public static void ListGoalNames()
    {
        int num = 1;
        foreach (Goal i in _goals)
        {
            Console.WriteLine($"{num}.{i._shortname}");
            num ++;
        }
    } 
    public static void ListGoalDetails()
    {
        foreach (Goal i in _goals)
        {
            Console.WriteLine(i.GetDetailsString());
        }
        Thread.Sleep(3000);
    }
    public static void CreateGoal()
    {
        Console.Write($"\nWhat kind of Goal would you like to create?\n\n1. Simple goal\n2.Eternal goal\n3. Checklist goal\n\nEnter your selection: ");
        string input = Console.ReadLine(); 
        if (input == "1")
        {
            Console.WriteLine("What is the name of this goal: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWrite a short description of this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("\nHow many points is this goal worth: ");
            string points = Console.ReadLine();
            SimpleGoal newgoal = new SimpleGoal(name, description, points);
            _goals.Add(newgoal);
        }
        else if (input == "2")
        {
            Console.WriteLine("What is the name of this goal: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWrite a short description of this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("\nHow many points is this goal worth: ");
            string points = Console.ReadLine();
            EternalGoal newgoal = new EternalGoal(name, description, points);
            _goals.Add(newgoal);
        } 
        else if (input == "3")
        {
            Console.WriteLine("What is the name of this goal: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nWrite a short description of this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("\nHow many points is this goal worth: ");
            string points = Console.ReadLine();
            Console.WriteLine("How many times do you want to complete this goal: ");
            string target = Console.ReadLine();
            Console.WriteLine($"\nHow many bonus points is this goal worth: ");
            string bonus = Console.ReadLine();

            ChecklistGoal newgoal = new ChecklistGoal(name, description, points, Int32.Parse(target),0,Int32.Parse(bonus));
            _goals.Add(newgoal); 
        }
        else 
        {

        }
    }
    public static void RecordGoal()
    {
        Console.WriteLine("Which goal would you like to record?\n");
        ListGoalNames();
        int input = Int32.Parse(Console.ReadLine()) - 1;
        _goals[input].RecordEvent();
    }
    public static void SaveGoals()
    {
        Console.WriteLine("Enter file name: ");
        string _filename = Console.ReadLine();
        System.IO.StreamWriter file = new System.IO.StreamWriter($"c:\\{_filename}.txt");
        foreach (Goal i in _goals)
        {
            file.WriteLine(i.GetStringRepresentation());
        }
        file.WriteLine(_score);

        file.Close();
    }
    public static void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string _fileload = Console.ReadLine();
        List<string> _list = new List<string>();
        _list = File.ReadAllLines($"c:\\{_fileload}.txt").ToList();

        foreach (string i in _list)
        {
            List<string> _goalList = new List<string>();
            _goalList = i.Split('|').ToList();
            if (_goalList[0] == "simplegoal")
            {
                SimpleGoal goal = new SimpleGoal(_goalList[1],_goalList[2],_goalList[3]);
                if (_goalList[4] == "True")
                {
                    goal.SetIsComplete(true);
                }
                _goals.Add(goal);
            }
            else if (_goalList[0] == "eternalgoal")
            {
                EternalGoal goal = new EternalGoal(_goalList[1],_goalList[2],_goalList[3]);
                _goals.Add(goal);
            }
            else if (_goalList[0] == "checklistgoal")
            {
                ChecklistGoal goal = new ChecklistGoal(_goalList[1],_goalList[2],_goalList[3],Int32.Parse(_goalList[4]),Int32.Parse(_goalList[5]),Int32.Parse(_goalList[6]));
                _goals.Add(goal);
            }
            else
            {
                _score = Int32.Parse(_goalList[0]);
            }
        }
    }

}