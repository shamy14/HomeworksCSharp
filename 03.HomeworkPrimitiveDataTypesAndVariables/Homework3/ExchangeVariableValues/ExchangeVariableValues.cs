using System;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchange: a={0} and b={1}", a, b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After the exchange: a={0} and b={1}", a, b);

    }
}
