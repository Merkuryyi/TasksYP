using System;
using System.IO;
class Program
{
    static void Main()
    {
        string lines = File.ReadAllText(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\num.txt");
        string[] nums = lines.Split(new char[] { ' ', ',' });
        int[] Numbers = new int[nums.Length];
        string[] xNum = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            Numbers[i] = Convert.ToInt32(nums[i]);
            if (Numbers[i] % 2 != 0)
            {
                xNum[i] = Convert.ToString(Numbers[i]);
            }
            
        }
        using (StreamWriter writer = new StreamWriter(@"C:\Users\public.COPP\RiderProjects\ConsoleApplication4\ts\num.txt"))
        {
            for (int i = 0; i < nums.Length; i++)
            {
                writer.Write(xNum[i] + " " );
            }
        }
    }
}