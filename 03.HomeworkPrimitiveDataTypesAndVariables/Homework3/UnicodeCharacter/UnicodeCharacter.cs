using System;
class UnicodeCharacter
{
    static void Main()
    {
        int value = 42;
        Console.WriteLine("42 in hexadecimal is: {0:X}", value);
        char unicode = '\u002A';
        Console.WriteLine(unicode);
    } 
}