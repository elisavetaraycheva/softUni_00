using System;

// Problem 4.Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements. 

class NumberComparer
{
    static void Main(string[] args)
    {
        double Number1;
        Double.TryParse(Console.ReadLine(), out Number1);
        double Number2;
        Double.TryParse(Console.ReadLine(), out Number2);

        Console.WriteLine("{0}", (Number1 > Number2) ? Number1 : Number2);
    }
}

