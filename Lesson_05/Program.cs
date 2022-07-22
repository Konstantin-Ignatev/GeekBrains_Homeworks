// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

        return newArray;
}

int FindEven(int[] newArray)
{
    int count = 0;

    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] % 2==0) count++;
    
    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное трехзначное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное трехзначное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

if(min > 99 && max < 1000)
{
    int[] array = CreateRandomArray(size, min, max);
    ShowArray(array);
    Console.Write($"Количество чётных трехзначных чисел в массиве: {FindEven(array)}");
}

else Console.Write("Оба числа должны быть трехзначными. Введите числа заново.");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

        return newArray;
}

int FindEvenSum(int[] newArray)
{
    int sum = 0;

    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] % 2==1)
            sum = sum + newArray[i];

    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.Write($"Сумма нечетных чисел в массиве: {FindEvenSum(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");
    for(int i=0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Max(int[] array)
{;
    int max = array[1];

    for(int i = 0; i < array.Length; i++)
        
        if(array[i] > max) max = array[i];

    return max;
}

int Min(int[] array)
{
    int min = array[1];

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];

    return min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size);

ShowArray(arr);

int max = Max(arr);
int min = Min(arr);

Console.WriteLine("Максимальный элемент массива = " + max);
Console.WriteLine("Минимальный элемент массива = " + min);

int dif = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + dif);