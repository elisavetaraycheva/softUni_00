using System;

// Problem 3.Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area 
// formatted with 2 digits after the decimal point. 

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        double r;
        Console.WriteLine("Enter radius: ");
        Double.TryParse(Console.ReadLine(), out r);
        Console.WriteLine("Perimeter is {0:f2} and Area is {1:f2} of circle with radius {2:f2}", 
            (2 * Math.PI * r), (Math.PI * Math.Pow(r, 2)), r);
    }
}

