// Write a program that reads the radius r of a circle and prints its perimeter and area with 2 digits after the decimal point. 
using System;

class CirclePerimetrArea
{
    static void Main()
    {
        Console.WriteLine("Enter the circle radius:");
        double r = double.Parse(Console.ReadLine());
        double p = r * 2 * 3.1416;
        double a = r * r * 3.1416;
        Console.WriteLine("Perimeter is {0:0.00}", p);
        Console.WriteLine("Area is {0:0.00}", a);
    }
}