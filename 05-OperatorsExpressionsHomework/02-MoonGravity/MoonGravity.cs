﻿using System;

class MoonGravity
{
    static void Main()
    {
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine(moonWeight);
    }
}
