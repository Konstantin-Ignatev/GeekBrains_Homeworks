// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Создайте массив из положительных и отрицательных чисел:");
    for(int i=0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

int PositiveNumbers(int[] newArray)
{
    int count = 0;

    for(int i = 0; i < newArray.Length; i++)
        if(newArray[i] > 0)
        count++;

    return count;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size);

ShowArray(arr);

Console.Write($"Количество чисел больше 0 =  {PositiveNumbers(arr)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string Point(int b1, int k1, int b2, int k2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}

Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Точка пересечения: {Point(b1, k1, b2, k2)}");