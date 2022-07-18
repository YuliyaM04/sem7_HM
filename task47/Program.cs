// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleArray(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

void PrintDoubleArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write(Math.Round(arr[i, j], 1) + " | ");
            else Console.Write(Math.Round(arr[i, j], 1));
        }
        Console.WriteLine();
    }
}

double[,] arrayResult = CreateDoubleArray(3, 4, 1, 10);
PrintDoubleArray(arrayResult);

