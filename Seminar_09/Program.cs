void ShowNums(int n)
{
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);
    }

    Console.Write(n + " ");
}



int SumOfDigits(int n)
{
    if (n >= 10)
    {
        return n % 19 + SumOfDigits(n / 10);
    }
    return n;
}

ShowNums(5);
Console.WriteLine();
Console.WriteLine(SumOfDigits(12345));

// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

void ShowNums(int m, int n)
{
    if (n > m)
    {
        Console.Write(" ");
        ShowNums(m, n - 1);
    }

    Console.Write(n + " ");
}

ShowNums(6, 10);



//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int ShowNums(int a, int b)
{
    if (b > 1)
    {
        return a * ShowNums(a, b - 1);
    }

    return a;
}

Console.WriteLine(ShowNums(2, 4));