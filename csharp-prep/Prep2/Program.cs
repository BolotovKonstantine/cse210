using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("Enter your percentage ");
        string percentage = Console.ReadLine();
        if (int.Parse(percentage) >= 90)
        {
            // Console.WriteLine("You got an A!");
            letter = "A";
        }
        else if (int.Parse(percentage) >= 80)
        {
            // Console.WriteLine("You got B");
            letter = "B";
        }
        else if (int.Parse(percentage) >= 70)
        {
            // Console.WriteLine("You got C");
            letter = "C";
        }
        else if (int.Parse(percentage) >= 60)
        {
            // Console.WriteLine("You got D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("You got F");
            letter = "F";
        }
        Console.WriteLine("Your letter grade is: " + letter);
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("You pass the course");
        }
        else
        {
            Console.WriteLine("You failed the course");
        }
    }
}