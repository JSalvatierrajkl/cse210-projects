using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction(); // Don't pass any information to get the default values
        Console.WriteLine(f1.GetFString());
        Console.WriteLine(f1.GetDecimal());

        Fraction f2 = new Fraction(6); // pass the first and last names
        Console.WriteLine(f2.GetFString());
        Console.WriteLine(f2.GetDecimal());

        Fraction f3 = new Fraction(7, 6); // pass all three variables
        Console.WriteLine(f3.GetFString());
        Console.WriteLine(f3.GetDecimal());

    }
}

