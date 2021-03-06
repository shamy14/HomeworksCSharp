﻿using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter integers for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integers for min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integers for max: ");
        int max = int.Parse(Console.ReadLine());
        if (min > max)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(min, max + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}
