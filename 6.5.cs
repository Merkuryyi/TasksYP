using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов ");
        int m = int.Parse(Console.ReadLine());
        int[,] originalMatrix = new int[n, m];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                originalMatrix[i,j] = rand.Next(0, 1 + 1);
                Console.Write(originalMatrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        int[,] resultMatrix = AddOnesCol(originalMatrix);

        Console.WriteLine("Матрица с добавленным столбцом:");
        PrintMatrix(resultMatrix);
    }
    static int[,] AddOnesCol(int[,] originalMatrix)
    {
        int rowCount = originalMatrix.GetLength(0);
        int colCount = originalMatrix.GetLength(1);
        int[,] resultMatrix = new int[rowCount, colCount + 1];
        for (int i = 0; i < rowCount; i++)
        {
            int onesCount = 0;
            for (int j = 0; j < colCount; j++)
            {
                resultMatrix[i, j] = originalMatrix[i, j];
                if (originalMatrix[i, j] == 1)
                {
                    onesCount++;
                }
            }
            resultMatrix[i, colCount] = (onesCount % 2 == 0) ? 0 : 1;
        }
        return resultMatrix;
    } 
    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}