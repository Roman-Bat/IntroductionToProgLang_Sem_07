﻿/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

// Метод создания двумерного массива с заполением
int[,] ArrayGenerator (int m, int n)
{
int[,] result = new int [m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        result[i, j] = i + j;
    }   
}
    return result;
}
// Метод вывода двумерного массива
void PrintDoubleArray (int[,] DoubleArray)
{
    for (int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            Console.Write($"{DoubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}


int [,] DoubleArray = ArrayGenerator(3, 4);
PrintDoubleArray(DoubleArray);
