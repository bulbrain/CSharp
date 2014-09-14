// Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].
using System;

class randomNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the max:");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        if (min < max)
        {
            for (int i = 0; i < n; i++)
                {
                Console.Write(rnd.Next(min, max) + " ");
                }
        }
        else
        {
            Console.WriteLine("Min should be lower than max.");
        }
    }
}