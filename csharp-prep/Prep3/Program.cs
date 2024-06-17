using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Boolean guess = false;
        while (guess == false)
        {
            Console.WriteLine("Guess the number:");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            if (guessNumber == number)
            {
                guess = true;
                Console.WriteLine("You guessed it");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}