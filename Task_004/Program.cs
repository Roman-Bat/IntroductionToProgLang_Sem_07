/*
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

// Метод вывода двумерного массива
void PrintDoubleArray (int[,] DoubleArray)
{
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            Console.Write($"{DoubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}

int GetSum(int[,] doubleArray)
{
    int result = 0;
    int index = 1;
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if(i == j) {result = result + doubleArray[i, j]; Console.WriteLine($"Число № {index} по диагонали {doubleArray[i, j]}"); index ++;}
        }
     }
    Console.WriteLine($"Сумма диагонали = {result}");
    return result;
}
int [,] DoubleArray = ArrayGenerator(4, 4, 0, 10);
PrintDoubleArray(DoubleArray);
GetSum(DoubleArray);