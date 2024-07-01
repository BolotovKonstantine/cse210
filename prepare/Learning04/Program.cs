using System;

class Program
{
    static void Main(string[] args)
    {
     Assignment assignment = new Assignment("BKN", "Multiplication");
     Console.WriteLine(assignment.GetSummary());
     MathAssignment mathAssignment = new MathAssignment("section 4", "Problens 4-2", "BKN", "Multiplication");
     Console.WriteLine(mathAssignment.GetSummary() + mathAssignment.GetHomeWorkList());
     WritingAssignment writingAssignment = new WritingAssignment("BKN", "War", "WW 2");
     Console.WriteLine(writingAssignment.GetSummary() + writingAssignment.GetWritingInformation());
    }
}