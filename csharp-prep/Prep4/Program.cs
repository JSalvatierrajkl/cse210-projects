using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int inputNumber = -1;
        List<int> numbers = new List<int>();
        // Add the numbers to the list
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }
        
        // Additioning every number
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = number + sum;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Averaging numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Get the largest number
        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

    }
}