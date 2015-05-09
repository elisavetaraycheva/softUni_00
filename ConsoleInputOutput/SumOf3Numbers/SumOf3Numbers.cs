using System;


// Problem 1.Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum. 

class SumOf3Numbers
{
    static void Main(string[] args)
    {
        double sum = 0.0;
        for (int i = 0; i < 3; i++)
        {
            double Number;
            Double.TryParse(Console.ReadLine(), out Number);
            sum += Number;
        }
        Console.WriteLine(sum);
    }
}

