// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create2DArray(int rows, int cols, int cols2)
{
    return new int[rows, cols, cols2];
}

void Fill2DArray(int[,,] array)
{
    int m = 10;
    int ind = 1;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = m;
                m = m + ind;
            }

}

void MixArray(int[,,] array)
{
    Random rnd = new Random();
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                l = rnd.Next(0, array.GetLength(1));
                if (array[i, j, k] == array[i, l, k]) continue;
                else
                    (array[i, j, k], array[i, l, k]) = (array[i, l, k], array[i, j, k]);
            }
}

void Print2DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");

            Console.WriteLine();
        }
}


int maxItems = 89;
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int columns2 = InputNum("Введите количество столбцов2: ");


int[,,] my2DArray = Create2DArray(rows, columns, columns2);
Fill2DArray(my2DArray);


if (rows * columns * columns2 > maxItems) Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначныи числами! Элементов в массиве больше!");
else
{
    MixArray(my2DArray);
    Print2DArray(my2DArray);
}


