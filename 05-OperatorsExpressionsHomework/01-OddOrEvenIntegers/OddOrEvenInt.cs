using System;

class OddOrEvenInt
{
    static void Main()
    {
        Console.WriteLine("Write a number to check if its odd ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToBoolean(n % 2) ? "true" : "false");
    }
}
