using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++)
        {
            Console.Write("{0} \n\r",i);
        }
    }
}
