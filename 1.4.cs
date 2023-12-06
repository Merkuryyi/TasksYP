using System;

class RandomArray 
{
    static void Main() 
    {
        Console.Write("Введите начало диапазона ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец диапазона ");
        int b = Convert.ToInt32(Console.ReadLine());
        int size = b - a;
        int[] array = new int [size];
        Random rand = new Random();
        for(int i = 0; i < size; i++)
        {
            array[i] = rand.Next(a, b + 1);
            Console.Write(array[i] + " ");
        }
    }
}