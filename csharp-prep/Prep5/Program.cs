using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string name = Name();
        int number = Number();
        int square = Square(number);
        Display(name, square);
    }
        

    static void Welcome()
    {
        Console.WriteLine("Welcome to this program");
    }
    static string Name()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int Number()
    {
        Console.Write("Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }

    static int Square(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }

    static void Display (string name, int square)
    {
        Console.Write($"Brother {name}, the square of your number is {square}");
    }

}