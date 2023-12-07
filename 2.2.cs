using System;
class array 
{
    static void Main()
    {
        int a = 1;
        int size = 20;
        int[] array = new int [size];
        for (int i = 0; i < size; i++)
        {
            array[i] = a;
            Console.Write(array[i] + " ");
            a += 2;
        }
    }
}