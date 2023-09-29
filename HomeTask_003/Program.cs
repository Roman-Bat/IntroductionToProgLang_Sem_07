/*
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3.
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
// Метод поиска элемента по числу от пользователя 
void SumOfColums(int[,] randArray)
{
    
    for (int i = 0; i < randArray.GetLength(1); i++)
    {
        double result = 0;
        Console.WriteLine($"Считаем элементы столбца {i+1} :");
    for (int j = 0; j < randArray.GetLength(0); j++)
        {
          result += randArray[j, i];
          if (j == 0) {Console.Write("(");}
          Console.Write($"{randArray[j, i]}");
          if (j < randArray.GetLength(0) - 1) {Console.Write(" + ");}
          if (j == randArray.GetLength(0) - 1) {Console.Write(")");}
        } 
        result = Math.Round(result / randArray.GetLength(0), 2);
        Console.WriteLine($" / {randArray.GetLength(0)} = {result} ");
    }
}


Console.WriteLine();
int [,] doubleArray = ArrayGenerator(2, 2, 0, 10);
Console.WriteLine("Создаем рандомный массив");
PrintDoubleArray(doubleArray);
Console.WriteLine();
SumOfColums(doubleArray);

