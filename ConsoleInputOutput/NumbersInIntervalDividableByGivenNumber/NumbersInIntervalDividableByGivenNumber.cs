using System;

// Problem 11.Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0. 

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        int Number1;
        Int32.TryParse(Console.ReadLine(), out Number1);
        int Number2;
        Int32.TryParse(Console.ReadLine(), out Number2);
        int Count = 0;
        for (int i = Number1; i <= Number2; i++)
        {
            if (i % 5 == 0) 
                Count++;
        }
        Console.WriteLine(Count);


    }
}

