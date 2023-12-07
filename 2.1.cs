using System;
class array 
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int size = 100;
        int[] array = new int [size];
        for (int i = 0; i < size; i++)
        {
            array[i] = a;
            Console.Write(array[i] + " ");
            a -= 3;
        }
    }
}