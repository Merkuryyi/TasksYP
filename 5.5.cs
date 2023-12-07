using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\numsTask5.txt");
            string[] numberStrings = input.Split(' ', ',', '\n');

            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
            int srz = Pro(numbers);
            Console.WriteLine(srz);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }

    static int Pro(int[] numbers)
    {
        int count = 0;
        int sum = 0;
        int indexMax = 0; 
        int min = int.MaxValue;
        int indexMin = 0; 
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                indexMin = i;
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
                indexMax = i;
            }
        }

        if (indexMax > indexMin)
        {
            for (int i = indexMin + 1; i < indexMax; i++)
            {
                sum += numbers[i];
                count++;
            }
        }
        else if (indexMax < indexMin)
        {
            for (int i = indexMax + 1; i < indexMin; i++)
            {
                sum += numbers[i];
                count++;
            }
        }
        return sum/count;
    }
}