using System;

class PrintMyName
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        Console.WriteLine("My name is {0} !", Name);
    }
}
