using System;

// Problem 8.Numbers from 1 to n
// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. 

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        int NumberCount;
        Int32.TryParse(Console.ReadLine(), out NumberCount);
        for (int i = 0; i < NumberCount; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
}

