// Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());
        double p = 2 * width + 2 * height;
        double a = width * height;
        Console.WriteLine("Perimeter is: {0}", p);
        Console.WriteLine("Area is {0}", a);
    }
}