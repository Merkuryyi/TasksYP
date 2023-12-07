using System;
using System.Security.Cryptography;
class Month
{
    static void Main(string[] args) 
    {
        int[,] temperature = new int[30 + 1, 12 + 1];
        Random rand = new Random();
        temperature[0, 0] = 0;
        for (int i = 1; i <= 30 ; i++) 
        {
            for (int j = 1; j <= 3; j++) 
            {
                temperature[i, j] = rand.Next(-15, -5); 
            }
        }
        
        for (int i = 1; i <= 30 ; i++) 
        {
            for (int j = 4; j <= 6; j++) 
            {
                temperature[i, j] = rand.Next(5, 10);
            }
        }
        for (int i = 1; i <= 30 ; i++) 
        {
            for (int j = 7; j <= 9; j++) 
            {
                temperature[i, j] = rand.Next(10, 15);
                
            }
        }
        for (int i = 1; i <= 30 ; i++) 
        {
            for (int j = 10; j <= 12; j++) 
            {
                temperature[i, j] = rand.Next(-25, -10); 
            }
        }
        for (int i = 1; i <= 30; i++)
        {
            for (int j = 1; j <= 12 ; j++)
            {
                temperature[0, j ] = j ;
                temperature[i , 0] = i ;
            }
        }
        for (int i = 0; i <= 30; i++)
        {
            for (int j = 0; j <= 12; j++)
            {
                Console.Write(temperature[i, j] + "\t" );
            }
            Console.WriteLine();
        }
        
        int[] Temper = Calculate(temperature);
        
        
        for (int i = 1; i <= 12; i++) 
        {
            Console.Write("\n" + i  + ": " + Temper[i]);
        }
    }
    static int[] Calculate(int[,] temperature) 
    {
        Console.WriteLine();
       
        int[] Temper = new int[13];
        for (int i = 1; i <= 12; i++) 
        {
            int sum = 0;
            for (int j = 1; j <= 30; j++) 
            {
                sum += temperature[j, i];
            }
            Temper[i] = sum / 30;
            
        }
        return Temper;
        
    }
}
