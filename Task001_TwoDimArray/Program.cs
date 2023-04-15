//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int SizeOfArray(string i)
{
    System.Console.Write($"Enter {i}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

double CreateArrayRange(string i)
{
    System.Console.Write($"Enter {i}: ");
    double x = double.Parse(Console.ReadLine());
    return x;
}

double[,] CreateArray()
{
    double[,] Array = new double[SizeOfArray("m"), SizeOfArray("n")];
    double a = CreateArrayRange("lower limit of your array");
    double b = CreateArrayRange("upper limit of your array");
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = Math.Round(new Random().NextDouble() * (b - a) + a, 2);
        }
    }
    return Array;
}

void PrintArray(double[,] Array)
{
     for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(CreateArray());