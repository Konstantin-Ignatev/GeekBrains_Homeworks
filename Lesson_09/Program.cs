// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4


int numberLength(int n)
{

    if(n < 0)
    {
        return numberLength(-n);
    }
    else if(n == 0)
    {
        return 0;
    }
    else
    {
        return 1 + numberLength(n/10);
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nКол-во цифр в числе {numberLength(n)}: ");
/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Sum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    Sum(numberM, numberN, sum);
}

Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Sum(M, N, sum);
*/