using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\numsTask1.txt");
            string[] strings = input.Split(' ', ',', '\n');
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length % 2 == 1)
                {
                    Console.Write(strings[i] + " ");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
}