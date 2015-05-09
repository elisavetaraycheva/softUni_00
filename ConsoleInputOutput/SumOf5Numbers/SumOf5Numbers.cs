using System;

// Problem 7.Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, separated by a space), 
// calculates and prints their sum.

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        string sLine = Console.ReadLine();
        string[] Nums = sLine.Split(' ');
        double sum = 0;
        for (int i = 0; i < Nums.Length; i++)
        {
            double Num;
            Double.TryParse(Nums[i], out Num);
            sum += Num;
        }
        Console.WriteLine(sum);
    }
}

