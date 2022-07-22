int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++);
        for(int j = 0; j < newArray.GetLength(1); j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
            
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
    }
}


int[,] Revers2dArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of rows and colums is not the same!");
        return array;
    }

    for(int i=0; i < array.GetLength(0) -1; i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[i];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
}

int[,] Cut2Array(int[,] array)
{
    int iMin = 0, jMin = 0;

    for(int i=0; i < array.GetLength(0) -1; i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Введите {i+1} элемент массива: ");
            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }

    for(int j = 0; j < array.GetLength(1, j++)
        array[IMin, j] = 0;
    for(int j = 0; j < array.GetLength(1, j++)
        array[i, jMin] = 0;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine();
