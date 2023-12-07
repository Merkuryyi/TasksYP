using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\input.txt"); 
        int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(lines[1]);
        using (StreamWriter writer = new StreamWriter(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\output.txt"))
        {
            for (int i = 0; i < n; i++)
            {
                int[] ticketNumbers = lines[i + 2].Split(' ', '\n').Select(int.Parse).ToArray();
                int count = ticketNumbers.Count(num => chosenNumbers.Contains(num));
                if (3 <= count)
                {
                    writer.WriteLine("Lucky");
                }
                else
                {
                    writer.WriteLine("Unlucky");
                }
            }
        }
    }
}