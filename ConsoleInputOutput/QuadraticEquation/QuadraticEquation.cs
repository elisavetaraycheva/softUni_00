using System;


class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a;
        Double.TryParse(Console.ReadLine(), out a);
        double b;
        Double.TryParse(Console.ReadLine(), out b);
        double c;
        Double.TryParse(Console.ReadLine(), out c);

        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0) 
            Console.WriteLine("No real roots");
        else
            Console.WriteLine("x1 = {0}, x2 = {1}", ((-b + Math.Sqrt(D)) / (2.0 * a)), ((-b - Math.Sqrt(D)) / (2.0 * a)));
    }
}

