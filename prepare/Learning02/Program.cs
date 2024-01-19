using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();

    job1._jobTitle = "developer"; 
    job1._company = "Nike";
    job1._endYear = 2022;
    job1._startYear = 2018;  

    Job job2 = new Job();

    job2._jobTitle = "Manager";
    job2._company = "costa vida";
    job2._startYear = 2020;
    job2._endYear = 2021;

    Resume myResume = new Resume();

    myResume.Display();
    }
  


}
