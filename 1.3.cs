using System;
using System.Collections.Generic;
class list
{
    static void Main()
    {
        int cmax = 0;
        string maxline = "";
        List<string> words = new List<string>();
        while (true)
        {
            string line  = Console.ReadLine();
            if (line == "")
            {
                break;
            }
            words.Add(line);
            if (cmax < line.Length)
            {
                cmax = line.Length;
                maxline = line;
            }
              
        }
        Console.WriteLine($"Самый длинный элемент: {maxline}");
        int cmin = 0;
        string minline = "";
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Length < cmax)
            {
                cmin = words[i].Length;
                minline = words[i];
            }
        }
        Console.WriteLine($"Самый короткий элемент: {minline}");
    }
}