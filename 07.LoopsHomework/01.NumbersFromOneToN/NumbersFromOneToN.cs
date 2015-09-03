using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            Console.Write("{0} ", i);
        }
    }
}
