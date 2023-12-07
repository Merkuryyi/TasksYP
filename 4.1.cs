using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int product = Find(n);
        Console.WriteLine("Произведение натуральных чисел, кратных трём и непревышающих n: " + product);
    }
    static int Find(int n)
    {
        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }
        return product;
    }
}