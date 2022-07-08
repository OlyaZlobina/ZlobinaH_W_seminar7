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

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int[,] SimpleArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j= 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max+1);
        }
    }
    return newArray;
}

void PrintSimpleArray(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// bool FindElementInArray(int [,] Array, int el)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if(Array[i,j] == el) return true;
//         }
//     }
//     return false;
// }


bool FindElementArray(int[,] Array, int r, int c)  // мне показалось, что по условию задачи нужно определить есть ли элемент на заданной позиции.
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if(i==r && j==c) return true;

        }
    }
    return false;
}



Console.Clear();
Console.Write("Input rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = SimpleArray(Rows, Columns, 0, 10);
PrintSimpleArray(myArray);
Console.Write("Input the position element by row: ");
int R = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the position element by column: ");
int C = Convert.ToInt32(Console.ReadLine());
if(FindElementArray(myArray, R,C))
{
    Console.WriteLine($"{R}, {C} -> elenent found");
}
else
{
    Console.WriteLine($"{R}, {C} -> elenent not found");
}



// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] ArrayRandom(int row, int column, int min, int max)
{
    int[,] newArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i,j] = new Random().Next(min, max);
        }
    }
    return newArray;
}

double[] ArifmeticMeanOfNumbersInColumns(int[,] ourArray)
{   
    double[] arifmeticMeanOfElemets = new double[ourArray.GetLength(1)];
    for (int i = 0; i < ourArray.GetLength(1); i++)
    {
        double summOfElements = 0;
        for (int j = 0; j < ourArray.GetLength(0); j++)
        {
            summOfElements += ourArray[j,i];
        }
        arifmeticMeanOfElemets[i] = Math.Round(summOfElements / ourArray.GetLength(0), 2);
    }
    return arifmeticMeanOfElemets;
}


void PrintNewArray(int [,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Input rows: ");
int Rw = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int Col = Convert.ToInt32(Console.ReadLine());
int[,] myNewArr = ArrayRandom(Rw, Col, 0, 10);
PrintNewArray(myArray);

double [] Result = ArifmeticMeanOfNumbersInColumns(myNewArr);
Console.WriteLine($"Arifmetic mean of each column = {String.Join("; ",Result)}");
