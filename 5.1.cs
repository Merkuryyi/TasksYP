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
            int product = Pro(numbers);
            Console.WriteLine(product);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
    static int Pro(int[] numbers)
    {
        int product = 1;
        int min = int.MaxValue;
        int index = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                index = i;
            }
        }
        for(int i = index; i < numbers.Length; i++)
        {
            product *= numbers[i];
          
        }
        return product;
    }
}