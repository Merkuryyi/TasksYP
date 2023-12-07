using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText("numsTask3.txt");
            string[] numberStrings = input.Split(',');

            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
            double ratio = FindMinMaxRatioBeforeZero(numbers);

            Console.WriteLine("Отношение минимального к максимальному перед 0: " + ratio);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }

    static double FindMinMaxRatioBeforeZero(int[] numbers)
    {
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int num in numbers)
        {
            if (num == 0)
            {
                break; 
            }
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }

        if (min == int.MaxValue || max == int.MinValue)  
        {
            Console.WriteLine("Перед 0 не найдено целых чисел.");
            return 0;
        }

        return (double)min / max;  
    }
}