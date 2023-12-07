using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число ");
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        if (a > 0)
        {
            Console.WriteLine("Введите числа ");
            for (int i = 0; i < 5; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b < 0)
                {
                    break;
                }
                else if (b % a == 0)
                {
                    sum += b;
                }
            }
            Console.WriteLine($"Сумма = {sum}");
        }
        else
        {
            Console.Write("Нужно положительное");
        }
    }
}