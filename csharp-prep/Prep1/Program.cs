using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? James");
        string firstname = Console.ReadLine();
        Console.Write("What is your second name? ");
        string secondname = Console.ReadLine();
        Console.WriteLine($"Your name is {secondname}, {firstname} {secondname}");
    }
}