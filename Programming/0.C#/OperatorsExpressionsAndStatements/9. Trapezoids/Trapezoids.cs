// Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter height H:");
        decimal h = decimal.Parse(Console.ReadLine());
        decimal c;
        c = ((a + b) / 2) * h;
        Console.WriteLine("Area is {0}", c);
    }
}