using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\Ксюша\RiderProjects\ts\numsTask1.txt");
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
        int sum = 0;
        int min = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
          
        }

        int count = 0;
        foreach (int num in numbers)
        {
            if (num == min)
            {
                break; 
            }
            else
            {
                sum += num;
                count++;
            }
        }
        return sum/count;
    }
}