using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string input = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\water.txt");
            string[] numbers = input.Trim().Split(' '); 
            int[] height = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                height[i] = int.Parse(numbers[i]);
            }
            int maxArea = MaxArea(height);
            Console.WriteLine("Максимальная площадь контейнера: " + maxArea);
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
    }
    static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int cArea = (right - left) * Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, cArea);
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}