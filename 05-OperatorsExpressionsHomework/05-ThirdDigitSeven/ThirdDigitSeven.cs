using System;

class ThirdDigitSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}", (n / 100) % 10 == 7);
    }
}
