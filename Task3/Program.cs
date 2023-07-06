// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
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

void ArrayProductMatrix(int[,] arrayFirst, int[,] arraySecond, int[,] arrayProduct)
{

    for (int i = 0; i < arrayProduct.GetLength(0); i++)
        for (int j = 0; j < arrayProduct.GetLength(1); j++)
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
                arrayProduct[i, j] += arrayFirst[i, k] * arraySecond[k, j];
}

int rowsFirst = InputNum("Введите количество строк матрицы 1: ");
int columnsFirst = InputNum("Введите количество столбцов матрицы 1: ");
int minValueFirst = InputNum("Введите минимальное значение диапазона матрицы 1: ");
int maxValueFirst = InputNum("Введите максимальное значение диапазона матрицы 1: ");

int rowsSecond = InputNum("Введите количество строк матрицы 2: ");
int columnsSecond = InputNum("Введите количество столбцов матрицы 2: ");
int minValueSecond = InputNum("Введите минимальное значение диапазона матрицы 2: ");
int maxValueSecond = InputNum("Введите максимальное значение диапазона матрицы 2: ");

int[,] myArrayFirst = Create2DArray(rowsFirst, columnsFirst);
Fill2DArray(myArrayFirst, minValueFirst, maxValueFirst);
Print2DArray(myArrayFirst);
Console.WriteLine();

int[,] myArraySecond = Create2DArray(rowsSecond, columnsSecond);
Fill2DArray(myArraySecond, minValueSecond, maxValueSecond);
Print2DArray(myArraySecond);
Console.WriteLine();

if (columnsFirst != rowsSecond) Console.WriteLine("Произведение матриц найти нельзя!");
else
{
    int[,] myArrayProduct = Create2DArray(rowsFirst, columnsFirst);
    ArrayProductMatrix(myArrayFirst, myArraySecond, myArrayProduct);
    Print2DArray(myArrayProduct);
}