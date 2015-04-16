using System;

class BeerTime
{
    static void Main()
    {
        string time = Console.ReadLine();
        DateTime dt = DateTime.Parse(time);
        if (dt.Hour >= 13 || dt.Hour <= 3)
        {
            Console.WriteLine("Beer time.");
        }
        else
        {
            Console.WriteLine("No beer time.");
        }
        Console.ReadLine();
    }
}
