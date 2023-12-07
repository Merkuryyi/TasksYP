using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\Ксюша\RiderProjects\ts\numsTask2.txt");
            string[] numbers = input.Split(';');
            float[] array = new float[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                float.TryParse(numbers[i], out array[i]);
            }
            float sum = Sum(array);
            Console.WriteLine("Сумма положительных элементов до нуля: " + sum);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
    static float Sum(float[] array)
    {
        float sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                break; 
            }
            else
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
        }
        return sum;
    }
}