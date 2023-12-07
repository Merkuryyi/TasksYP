using System;
using System.IO;

class Program
{
    static void Main()
    {
        string concWords = ConcWords(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\numsTask2.txt");
        Console.WriteLine("Результирующая строка:");
        Console.WriteLine(concWords);
    }
    static string ConcWords(string filename)
    {
        string result = "";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result += line + " "; 
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Ошибка при чтении файла: " + e.Message);
        }
        return result; 
    }
}