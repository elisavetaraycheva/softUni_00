using System;

// Problem 10.Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops. 


class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int NumberCount;
        Int32.TryParse(Console.ReadLine(), out NumberCount);

        int[] fib = new int[NumberCount];
        string sLine = String.Empty;
        for (int i = 0; i < NumberCount; i++)
        {
            
            if (i > 1)
                fib[i] = Next(fib[i - 2], fib[i - 1]);
            else
                fib[i] = i;
            sLine += fib[i].ToString() + " ";
        }
        Console.WriteLine(sLine);
    }

    public static int Next(int a, int b)
    {
        return a + b;
    }
}

