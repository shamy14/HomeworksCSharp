using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string type = Console.ReadLine();
        switch(type)
        {
            case "1":
                Console.Write("Please enter a int: ");
                int case1 = int.Parse(Console.ReadLine());
                Console.WriteLine(case1 + 1);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double case2 = double.Parse(Console.ReadLine());
                Console.WriteLine(case2 + 1);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string case3 = Console.ReadLine();
                Console.WriteLine("{0}*",case3);
                break;
            default: Console.WriteLine("Wrong type");
                break;
        }
    }
}
