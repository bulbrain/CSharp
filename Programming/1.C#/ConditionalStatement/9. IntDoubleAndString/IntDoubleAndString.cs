using System;

class IntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> Int");
        Console.WriteLine("2 --> Double");
        Console.WriteLine("3 --> String");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("Please enter an integer.");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2: Console.WriteLine("Please enter a double.");
                double dauble = double.Parse(Console.ReadLine());
                Console.WriteLine(dauble + 1);
                break;
            case 3: Console.WriteLine("Please enter a string.");
                string streeng = Console.ReadLine();
                Console.WriteLine("{0}*", streeng);
                break;
            default: Console.WriteLine("Invalid choice.");
                break;
        }
    }
}