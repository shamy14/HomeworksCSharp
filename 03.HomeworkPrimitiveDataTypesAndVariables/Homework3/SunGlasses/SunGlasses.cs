using System;
class SunGlasses
{
    private static void TopAndBottom(int height)
    {
        string frame = new string('*', 2 * height);
        string space = new string(' ', height);
        Console.WriteLine("{0}{1}{0}", frame, space, frame);
    }
    private static void middle(int height, int i)
    {
        string lens = new string('/', 2 * height-2);
        string middleFrame=string.Format("{0}{1}{0}",'*', lens);
        string connection=new string(' ', height);
        if (i == height / 2)
        {
            connection = new string('|', height);
        }
        Console.WriteLine("{0}{1}{0}", middleFrame, connection);

    }
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++) 
        {
            if(i==0||i==height-1){
                TopAndBottom(height);
            }
            else
            {
                middle(height, i);
            }
        }
    }
}
