using System;
using System.IO;

class Program
{
    static void Main()
    {
        string input = File.ReadAllText(@"C:\Users\Ксюша\RiderProjects\ts\numsTask2.txt");
        string[] numberss = input.Split(';');
        float[] array = new float[numberss.Length];
        for (int i = 0; i < numberss.Length; i++)
        {
            float.TryParse(numberss[i], out array[i]);
        }
        Array.Sort(array);
        for (int i = 0; i < numberss.Length; i++)
        {
            Console.Write(array[i] + "; ");
        }

        using (StreamWriter writer = new StreamWriter(@"C:\Users\Ксюша\RiderProjects\ts\numsTask2.txt")) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                writer.Write(Convert.ToString(array[i]) + ";");
            }
        }
    }
}