// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSum(int i)
{
    int sum = 0;

    while (i > 0)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    
    return sum;
}

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма всех цифр в числе равна: " + FindSum(i));



