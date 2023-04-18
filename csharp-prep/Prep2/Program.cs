using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int pGrade = int.Parse(userInput);
        string pLetter = "";
        if (pGrade >= 90)
        {
            pLetter = "A";
        }
        else if (pGrade >= 80)
        {
            pLetter = "B";
        }
        else if (pGrade >= 70)
        {
            pLetter = "C";
        }
        else if (pGrade >= 60)
        {
            pLetter = "D";
        }
        else
        {
            pLetter = "F";
        }

        Console.WriteLine($"Your grade in letter is {pLetter}");
        
        if (pGrade >=70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you will acomplish it for sure the next attempt");
        }
    }
}