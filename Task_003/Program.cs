/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// Метод создания двумерного массива с рандомными числами
int[,] ArrayGenerator (int m, int n, int min, int max)
{
int[,] result = new int [m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        result[i, j] = rand.Next(min, max);
    }   
}
    return result;
}

int[,] SqrtArrayPoint(int[,] doubleArray)
{
    int[,] result = new int [doubleArray.GetLength(0), doubleArray.GetLength(1)];
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if (i % 2 == 0
                && j % 2 == 0
            ) {result[i, j] = doubleArray[i, j] * doubleArray[i, j];}
            else {result[i, j] = doubleArray[i, j];}
        }   
    }
        return result;
}

// Метод вывода двумерного массива
void PrintDoubleArray (int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}

int [,] doubleArray = ArrayGenerator(4, 4, -9, 10);
PrintDoubleArray(doubleArray);
Console.WriteLine (); 
int[,] sqrtArray = SqrtArrayPoint(doubleArray);
PrintDoubleArray(sqrtArray);