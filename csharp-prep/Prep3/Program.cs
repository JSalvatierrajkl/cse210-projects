using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);
        int gNumber = -1;
        while (mNumber != gNumber)
        {
        Console.Write("What is your guess? ");
        string userInput = Console.ReadLine();
        gNumber = int.Parse(userInput);
        if (gNumber > mNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (gNumber < mNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        } 
        

    }
}