using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите а");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите б");
        int b = int.Parse(Console.ReadLine());
        int x1 = -2;
        int y1 = -3;
        int x2 = 0;
        int y2 = 2;
        int x3 = 2;
        int y3 = -3;
        int x = (x1 - a) * (y2 - y1) - (x2 - x1) * (y1 - b);
        int c = (x2 - a) * (y3 - y2) - (x3 - x2) * (y2 - b);
        int v = (x3 - a) * (y1 - y3) - (x1 - x3) * (y3 - b);
        if ((x >= 0 && c >= 0 && v >= 0) || (x <= 0 && c <= 0 && v <= 0))
        {
            Console.WriteLine("Принадлежит треугольнику");
        }
        else
        {
            Console.WriteLine("Не принадлежит треугольнике");
        }
    }
}