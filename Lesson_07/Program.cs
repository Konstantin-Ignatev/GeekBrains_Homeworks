// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayRandomNumbers(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Show2Array(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.Write("]");
 Console.WriteLine("");
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillArrayRandomNumbers(array);

Show2Array(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(10, 99);
            
            return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

}

void FindPosition(int[,] array, int pos1, int pos2)
{

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
            Console.WriteLine("Такого элемента в массиве нет");
            else Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]); 
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию 1 в двумерном массиве: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию 2 в двумерном массиве: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2Array(m, n);

Show2dArray(myArray);

FindPosition(myArray, pos1, pos2);

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7


int[,] SpiralMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int num = 1;

    for (int beta = 0; beta < columns - 2; beta++)
    {
        for (int i = 0 + beta; i < columns - beta; i++)
        {
            array[0 + beta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + beta; i < columns - beta; i++)
        {
            array[i, 3 - beta] = num;
            num++;
        }
        num--;
        for (int i = columns - 1 - beta; i >= 0 + beta; i--)
        {
            array[3 - beta, i] = num;
            num++;
        }
        num--;
        for (int i = columns - 1 - beta; i >= 1 + beta; i--)
        {
            array[i, 0 + beta] = num;
            num++;
        }
        num--;
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralMatrix(m, n);

Show2dArray(array);

