using System;
using System.Collections.Generic;
class list
{
    static void Main()
    {
        int sum = 0;
        int product = 1;
        List<int> value = new List<int>();
        while (true)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                break;
            }
            value.Add(a);
            sum += a;
            product *= a;
        }
        Console.WriteLine($"сумма = {sum} произведение = {product}");
    }
}