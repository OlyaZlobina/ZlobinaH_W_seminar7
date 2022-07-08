// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j  = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble()*10;
        }
    }
    return result;
}


void PrintGetArray(double [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]:f1} "); 
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Input number of rows: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int N = Convert.ToInt32(Console.ReadLine());
double[,] myArr = GetArray(M, N, 0, 10);
GetArray(M, N, 0, 10);
PrintGetArray(myArr);


