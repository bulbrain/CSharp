using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloworld = hello + " " + world;
        string full = (string)helloworld;
        Console.WriteLine(full);
    }
}