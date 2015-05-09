using System;

// Problem 9.Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
// Note that you may need to use a for-loop. 

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        int NumberCount;
        Int32.TryParse(Console.ReadLine(), out NumberCount);
        double sum = 0;
        for (int i = 0; i < NumberCount; i++)
        {
            double Number;
            Double.TryParse(Console.ReadLine(), out Number);
            sum += Number;
        }
        Console.WriteLine(sum);
    }
}

