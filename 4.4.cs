using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\numsTask4.txt");
            string[] numbers = input.Split(new char[] {' '});
            int[] nums = Array.ConvertAll(numbers, int.Parse);
            int t = Pro(nums);
            Console.WriteLine(t);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
    static int Pro(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nums[i+1])
            {
                count++;
            }
        }
        return count;  
    }
}