using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 1;i<=n;i++)
        {
            if(i%3==0 || i%7==0)
            {
                continue;
            }
            else
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
