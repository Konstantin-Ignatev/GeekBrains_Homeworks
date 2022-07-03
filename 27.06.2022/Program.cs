// Задача 10

int SecondNumber()
{
    int number;
    Console.Write("Input a three-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());

    number = number/10 % 10;

   return number;
}

Console.WriteLine("Second number is: " + SecondNumber());

// Задача 13 

int GetThirdDigit(int num)
{ 
    while (num >= 1000) num/= 10;
    num = num % 10;
    return num;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    
    Console.WriteLine("третье число: " + GetThirdDigit(number));
}
else
{
     Console.WriteLine("третьего числа нет");
}

// Задача 15

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
