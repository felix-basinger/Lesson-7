//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Read(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

 void Average()
 {
    System.Console.WriteLine("Enter the size of matrix: ");
    int m = Read("count of strings in the matrix");
    int n = Read("count of columns in the matrix");
    int[,] matrix = new int[m, n];
    int[] sum = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    System.Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            System.Console.Write(matrix[i, j] + " ");
         
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum[i] += matrix[j, i];
        }
    }

    int count = 1;
    for (int i = 0; i < n; i++)
    {
        double num = Convert.ToDouble(sum[i]);
        System.Console.Write($"Result of the {count} column = ");
        count++;
        System.Console.WriteLine(Math.Round(num / m, 2));
    }
 }

 Average();
