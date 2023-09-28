/*
(Дополнительная) Задать два рандомных массива одинаковой величины, и перемножить их поэлементно
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
   
    for (int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            Console.Write($"{DoubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}

int[,] multiplicationArray(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            result[i, j] = firstArray[i, j] * secondArray[i, j];
        }  
    }
    return result;
}

int [,] firstDoubleArray = ArrayGenerator(4, 4, 0, 10);
int [,] secondtDoubleArray = ArrayGenerator(4, 4, 0, 10);
Console.WriteLine("Сгенерированный массив:");
PrintDoubleArray(firstDoubleArray);
Console.WriteLine("Сгенерированный массив:");
PrintDoubleArray(secondtDoubleArray);
int[,] multiplicationArr = multiplicationArray(firstDoubleArray, secondtDoubleArray);
Console.WriteLine("Умножение массивов:");
PrintDoubleArray(multiplicationArr);