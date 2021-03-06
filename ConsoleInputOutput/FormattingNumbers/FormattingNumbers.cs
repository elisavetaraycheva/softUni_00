﻿using System;


// Problem 5.Formatting Numbers
// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and 
// a floating-point c and prints them in 4 virtual columns on the console. 
// Each column should have a width of 10 characters. 
// The number a should be printed in hexadecimal, left aligned; 
// then the number a should be printed in binary form, 
// padded with zeroes, then the number b should be printed with 2 digits after the decimal point, 
// right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

class FormattingNumbers
{
    static void Main(string[] args)
    {
        short a;
        Int16.TryParse(Console.ReadLine(), out a);
        double b;
        Double.TryParse(Console.ReadLine(), out b);
        double c;
        Double.TryParse(Console.ReadLine(), out c);
        Console.Write("|");
        Console.Write("{0,-10}", Convert.ToString(a, 16));
        Console.Write("|");
        Console.Write("{0}", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|");
        Console.Write("{0,10:f2}", b);
        Console.Write("|");
        Console.Write("{0,-10:f3}", c);
        Console.WriteLine("|");
    }
}

