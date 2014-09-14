using System;

class BiggerOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter the first number.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number.");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth number.");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fifth number.");
        double e = double.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The bigger number is: " + a);
        }
        else
            if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The bigger number is: " + b);
            }
            else
                if (c > a && c > b && c > d && c > e)
                {
                    Console.WriteLine("The bigger number is: " + c);
                }
                else
                    if (d > a && d > b && d > c && d > e)
                    {
                        Console.WriteLine("The bigger number is: " + d);
                    }
                    else
                    {
                        Console.WriteLine("The bigger number is: " + e);
                    }
    }
}