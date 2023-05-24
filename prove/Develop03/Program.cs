using System;

class Program
{
    static void Main(string[] args)
    {
        bool game = true;
        while (game == true)
        {
            Console.Clear();
            Reference r1 = new Reference();
            Console.WriteLine(r1.GetReference());
            Scripture s = new Scripture();
            Console.WriteLine();
            Console.WriteLine("Type '1' to continue or tap 'quit' to finish:");
            string inputOption = Console.ReadLine();
            if (inputOption == "quit")
            {
                game = false;
            }

            
        }
    }
}