using System;

class Program
{
    static void Main(string[] args)
    { 
        List<int> numbers = new List<int>();
        int sum = 0;
        float avg = 0;
        int largest = 0;
            
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        while (number != 0)
        { 
            numbers.Add(number); 
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
            avg = (float)sum / numbers.Count;
        }
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Largest number: " + largest);
    }
}