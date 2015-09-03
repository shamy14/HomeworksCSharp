using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());// p = holidays in the year
        int h = int.Parse(Console.ReadLine());// h = weekends Joro spends in his hometown
        double times = 0;
        if (year == 't'.ToString())
        {
            times += 3;
        }
        times += (52 - h) * 2 / 3 + p / 2 + h;
        Console.WriteLine((int)times);
    }
}
