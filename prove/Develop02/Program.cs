using System;

class Program
{
    
    static void Main(string[] args)
    {
    
        int inputNumber = -1;
        List<string> prompts = new List<string>() {"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "What did I see different today?",
        "How could you explain the best part of the day in one word", 
        "Did you see the hand of God today?", 
        "How did you face the problems?",
        "What could you do better for tomorrow?"};
        string date = "";
        string prompt = "";
        string response = "";
        var entries = new List<string> {"", "", ""};
        
        while (inputNumber != 0)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            string inputOption = Console.ReadLine();
            inputNumber = int.Parse(inputOption);
            

            if (inputNumber == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                Random rnd = new Random();
                int randIndex = rnd.Next(prompts.Count);
                string random = prompts[randIndex];
                Console.WriteLine(random);
                Journal entry1 = new Journal();
                entry1._date = theCurrentTime.ToShortDateString();
                entry1._prompt = (random);
                entry1._response = Console.ReadLine();
                date = entry1._date;
                prompt = entry1._prompt;
                entry1._entries.Add(entry1);
                entry1.Display();
            }
            
            
            else if (inputNumber == 2)
            {

            }

        }
    }
}
