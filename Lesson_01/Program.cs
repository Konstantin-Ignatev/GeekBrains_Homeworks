// Задача 2

void DayNumber(int num)
{
    if (num > 5 && num < 8)
    {
        Console.WriteLine(num + " - это выходной день");
    }
    else
    {
        Console.WriteLine(num + " - это будний день");
    }
}

Console.WriteLine("Напишите число, соответствующее дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

DayNumber(number);

// Задача 4

int a, b, c, max;

Console.Write("Input a number a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number c: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("Max number is " + max);

// Задача 6

int number;

Console.Write("Input a number: ");
number = Convert.ToInt32(Console.ReadLine());

if (number % 2==0)
{
Console.WriteLine("Yes");        
}
else
{
Console.WriteLine("No");
}

// Задача 8

int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = 1;

while(current <= n)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current++;
    }
    else
    {
    current++;
    }
}
