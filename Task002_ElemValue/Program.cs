//  Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
    int[] sum = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
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

void FindYourElem(int[,] matrix)
{
    System.Console.Write("Enter the first index: ");
    int a = int.Parse(Console.ReadLine());
    System.Console.Write("Enter the second index: ");
    int b = int.Parse(Console.ReadLine());
    if(a < 0 || b < 0)
    {
        System.Console.WriteLine("Too small value. Try again");
    }
    else
    {
        if(a <  matrix.GetLength(0) && b <  matrix.GetLength(1))
        {
            if(a < 0 && b < 0)
            {

            }
        System.Console.WriteLine($"Your element with value {a},{b} = {matrix[a, b]}");
        }
        else System.Console.WriteLine($"Your element with value {a},{b} IS NOT EXIST!");
    }
}
 
int[,] array = CreateArray();
PrintArray(array);
FindYourElem(array);