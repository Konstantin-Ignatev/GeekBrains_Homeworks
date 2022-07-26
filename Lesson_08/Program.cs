// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(10, 99);

    return newArray;
}

int[,] Reverse2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2Array(m, n);
Console.WriteLine($"\nИсходный массив: ");
Show2dArray(myArray);

Console.WriteLine($"\nОтсортированный массив: ");
Reverse2Array(myArray);
Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(10, 99);

    return newArray;
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2Array(m, n);

Console.WriteLine($"\nИсходный массив: ");
Show2dArray(myArray);

int minSumLine = 0;

int sumLine = SumLineElements(myArray, 0);

for (int i = 1; i < myArray.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(myArray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

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