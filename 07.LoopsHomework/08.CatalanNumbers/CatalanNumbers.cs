using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for N and K:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 1 || n >= 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        BigInteger Factorial2N = 1;
        BigInteger FactorialN = 1;
        BigInteger FacturialNPlus1 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            Factorial2N *= i;
            if (i <= n)
            {
                FactorialN *= i;
            }
        }
        for (int i = 1; i <= n + 1; i++)
        {
            FacturialNPlus1 *= i;
        }
        Console.WriteLine("Catalan(n)= {0}", Factorial2N / (FactorialN * FacturialNPlus1));
    }
}
