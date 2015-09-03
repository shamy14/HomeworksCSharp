using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        //Nullable <int> a = null;
        //Nullable <double> b = null;
        Console.WriteLine("a={0}\nb={1}", a, b);
        a += 5;
        b += 6.7;
        Console.WriteLine("After addition:\na={0}\nb={1}", a, b);
        a = 5;
        b = 6.7;
        Console.WriteLine("After assignment:\na={0}\nb={1}", a, b);
        a += null;
        b += null;
        Console.WriteLine("After adding null:\na={0}\nb={1}", a, b);
    }
}
