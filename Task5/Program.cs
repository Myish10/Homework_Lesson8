// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int columns = 4;

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}


void Fill2DArray(int[,] array, int rows, int cols)
{
    int size = rows * cols;
    int i = 0;
    int j = 0;
    int k = 1;
    int n = 0;
    while (k <= size)
    {
        while (j < array.GetLength(1) - n)
        {
            array[i, j] = k;
            k++;
            j++;
        }
        j--;
        i++;
        while (i < array.GetLength(0) - n)
        {
            array[i, j] = k;
            k++;
            i++;
        }
        i--;
        while (j > 0 + n)
        {
            j--;
            array[i, j] = k;
            k++;
        }
        
        while (i > 1 + n)
        {
            i--;
            array[i, j] = k;
            k++;
        }
        j++;
        n++;
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[,] my2DArray = Create2DArray(rows, columns);
Fill2DArray(my2DArray, rows, columns);
Print2DArray(my2DArray);


