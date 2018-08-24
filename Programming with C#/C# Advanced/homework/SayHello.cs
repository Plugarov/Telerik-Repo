using System;
class SayHello
{
    static void Main()
    {
        PrintName();
    }

    static void PrintName()
    {
        Console.Write("Please type your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }

}