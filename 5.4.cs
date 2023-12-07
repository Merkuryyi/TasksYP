using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\numsTask4.txt");
            string[] numberStrings = input.Split(' ', ',', '\n');
            int[] numbers = Array.ConvertAll(numberStrings, int.Parse);
            int sum = Sum(numbers);
            Console.WriteLine(sum);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
    static int Sum(int[] numbers)
    {
        int sum = 0;
        int max = int.MinValue;
        int index = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == max - 1)
            {
                sum += numbers[i];
            }
        }
        return sum;
    }
}