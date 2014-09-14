// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
// Use the Euclidean algorithm (find it in Internet). 
using System;

class calculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer.");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer.");
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int temp;
            temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine("The GCD is: " + a);
    }
}