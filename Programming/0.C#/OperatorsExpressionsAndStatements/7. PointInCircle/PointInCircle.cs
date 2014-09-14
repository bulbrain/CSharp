// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter X:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        double y = double.Parse(Console.ReadLine());
        bool inside = (x * x) + (y * y) <= (2 * 2);
        Console.WriteLine("Is {0}, {1} inside the circle? {2}", x, y, inside);
    }
}