using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int[]> tempDict = RandomTempDict();
        Dictionary<string, int> averageTemperatures = CalcAvTemp(tempDict);
        Console.WriteLine("Средние температуры для каждого месяца (отсортированные по возрастанию):");
        foreach (var month in averageTemperatures)
        {
            Console.WriteLine($"{month.Key}: {month.Value}");
        }
    }

    static Dictionary<string, int[]>RandomTempDict()
    {
        Dictionary<string, int[]> tempDict = new Dictionary<string, int[]>();
        Random random = new Random();

        for (int month = 1; month <= 3; month++)
        {
            int[] temperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-15, -5); 
            }
            string monthName = new DateTime(2023, month, 1).ToString("MMMM"); 
            tempDict.Add(monthName, temperatures);
        }
        for (int month = 4; month <= 6; month++)
        {
            int[] temperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-5, 10); 
            }
            string monthName = new DateTime(2023, month, 1).ToString("MMMM"); 
            tempDict.Add(monthName, temperatures);
        }
        for (int month = 7; month <= 9; month++)
        {
            int[] temperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(0,25); 
            }
            string monthName = new DateTime(2023, month, 1).ToString("MMMM"); 
            tempDict.Add(monthName, temperatures);
        }
        for (int month = 10; month <= 12; month++)
        {
            int[] temperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-25, -5 ); 
            }
            string monthName = new DateTime(2023, month, 1).ToString("MMMM"); 
            tempDict.Add(monthName, temperatures);
        }
        return tempDict;
    }

    static Dictionary<string,int> CalcAvTemp(Dictionary<string, int[]> temps)
    {
        Dictionary<string, int> averageTemps = new Dictionary<string, int>();

        foreach (var month in temps)
        {
            int totalTemperature = 0;
            foreach (var temperature in month.Value)
            {
                totalTemperature += temperature;
            }
            int average = totalTemperature / (int)month.Value.Length;
            averageTemps.Add(month.Key, average);
        }
        return averageTemps;
    }
}