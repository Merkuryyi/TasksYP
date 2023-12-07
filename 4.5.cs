using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите а");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите б");
        int b = int.Parse(Console.ReadLine());
        int x1 = -1;
        int x2 = 3;
        int y1 = -2;
        int y2 = 4;
        if (a > x1 && a < x2)
        {
            if (b > y1 && b < y2)
            {
                Console.WriteLine("Принадлежит");
            }
        }
        else
        { 
            Console.WriteLine("Не принадлежит");
        }
    }
}