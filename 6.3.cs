using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0 && a % 10 == 0)
        {
            Console.WriteLine("Число четное и кратно 10");
        }
        else
        {
            Console.WriteLine("Число не четное или не кратно 10");
        }
    }
}