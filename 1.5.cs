using System;

class Program
{
    static void Main()
    {
        string inputline = Console.ReadLine();
        
        string[] words = inputline.Split(new char[] { ' ', ',' });
        Console.WriteLine("Количество слов в строке: " + words.Length );
        string line = "Start " + inputline + " End";
        Console.WriteLine(line);
    }
}