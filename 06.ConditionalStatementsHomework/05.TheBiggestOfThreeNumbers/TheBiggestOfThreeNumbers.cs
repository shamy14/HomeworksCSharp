﻿using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for a, b and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(Math.Max(a, b), c));
    }
}
