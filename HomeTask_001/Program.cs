/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] DoubleArray(int m, int n)
{
    double [,] result = new double [m, n];
    Random rand = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i,j] = Math.Round(rand.NextDouble()*10, 2);
            }   
        }
    return result;
}

// Метод вывода двумерного массива
void PrintDoubleArray (double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"    {doubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}

PrintDoubleArray(DoubleArray(3, 4));