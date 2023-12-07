using System;
class array 
{
  static void Main()
  {
      int n = int.Parse(Console.ReadLine());
      int[,] array = new int[n, n];
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              array[i, 0] = 1;
              array[0, j] = 1;
          }
      }
      
      for (int i = 1; i < n; i++)
      {
          for (int j = 1; j < n; j++)
          {
              array[i, j] = array[i - 1, j] + array[i, j - 1];
          }
      }
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              
              Console.Write(array[i, j] + " " );
          }
          Console.WriteLine("");
      }
  }
}