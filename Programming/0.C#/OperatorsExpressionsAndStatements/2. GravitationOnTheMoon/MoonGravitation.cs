// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;

class MoonGravitation
{
    static void Main()
    {
        Console.WriteLine("Enter weight:");
        double EarthWeight = double.Parse(Console.ReadLine());
        double MoonWeight = EarthWeight * 0.17;
        Console.WriteLine("{0}kg on the Earth is {1}kg on the moon.", EarthWeight, MoonWeight);
    }
}