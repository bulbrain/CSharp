// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2). 
using System;

class InsideTriangleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter X:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        double y = double.Parse(Console.ReadLine());
        bool inside = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5) && (x >= 1);
        Console.WriteLine("Is {0}, {1} inside the circle? {2}", x, y, inside);
    }
}