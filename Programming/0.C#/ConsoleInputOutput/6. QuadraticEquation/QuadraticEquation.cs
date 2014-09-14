// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it.
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient A:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient B:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient C:");
        double c = double.Parse(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("There is one real root - x1: {0}", -c / b);
        }
        else if (discriminant > 0)
        {
            double xOne = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double xTwo = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("There are two real roots - x1: {0} and x2: {1}", xOne, xTwo);
        }
        else if (discriminant == 0)
        {
            double xOne = -(b / 2 * a);
            Console.WriteLine("There is one real root - x1: {0}", xOne);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }
    }
}