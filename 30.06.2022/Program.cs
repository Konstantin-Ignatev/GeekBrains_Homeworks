// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubes(int N)
{
int start = 1;
int end = N;
int count = 0;
int[] arr = new int[N];

for (int i = start; i <= arr.Length; i++)
{
  if (count < arr.Length)
  {
    arr[count] = i * i;
    count++;
  }
  else
    break;
}
for (int i = 0; i < arr.Length; i++) 
Console.Write(arr[i] + " ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cubes(number);