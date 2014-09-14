// Write a program that gets two numbers from the console and prints the greater of them. 
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal greater = Math.Max(a, b);
        Console.WriteLine("The greater number is: "+ greater);
    }
}