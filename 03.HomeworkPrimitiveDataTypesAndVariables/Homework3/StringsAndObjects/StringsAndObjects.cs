using System;
class StringsAndObjects 
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object concatenation = first + " " + second;
        string third = (string)concatenation;
        Console.WriteLine(third);
    }
}
