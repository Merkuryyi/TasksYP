using System;

class Program
{
    static void Main()
    {
        float[] array = { 1.24678f, 4.5f, 5.467f, -6.5f, -7.89675f };
        int size = array.Length;
        float[] plus = new float[array.Length];
        float[] minus = new float[array.Length];
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
       int j = 0;
       int a = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] > 0)
            {
                plus[j] = array[i];
                j++;
            } 
            if (array[i] < 0)
            {
                minus[a] = array[i];
                a++;
            }
        }
        Console.WriteLine("Отрицательный массив");
        for (int i = 0; i < size; i++)
        {
            Console.Write(minus[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Положительный массив");
        for (int i = 0; i < size; i++)
        {
            Console.Write(plus[i] + " ");
        }
    }
}