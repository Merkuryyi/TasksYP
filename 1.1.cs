using System;

class RandomArray 
{
    static void Main() 
    {
        Console.WriteLine("Введите начало диапазона ");
        int a = Convert.ToInt32(Console.ReadLine());
        int size = 10;
        int[] array = new int [size];
        Random rand = new Random(a);
        int min = 0;
        for(int i = 0; i < size; i++)
        { 
            min = array[0];
            array[i] = rand.Next();
            if (array[i] < min)
            {
                min = array[i];
            }
            Console.WriteLine(array[i]);
        }
        Console.WriteLine($"Мин. элемент = {min}");
    }
}