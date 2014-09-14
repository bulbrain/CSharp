// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
using System;

class randomize1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(rnd.Next(1, n + 1)+ " ");
        }
    }
}