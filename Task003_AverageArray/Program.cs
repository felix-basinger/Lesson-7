//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Read(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

 int[,] CreateArray()
 {
    System.Console.WriteLine("Enter the size of matrix: ");
    int m = Read("count of strings in the matrix");
    int n = Read("count of columns in the matrix");
    int[,] matrix = new int[m, n];
     
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    System.Console.WriteLine();
    return matrix;
 }

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
         
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Average(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum[i] += matrix[j, i];
        }
    }

    int count = 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double num = Convert.ToDouble(sum[i]);
        System.Console.Write($"Result of the {count} column = ");
        count++;
        System.Console.WriteLine(Math.Round(num / matrix.GetLength(0), 2));
    }
 }

int[,] array = CreateArray();
PrintArray(array);
Average(array);
