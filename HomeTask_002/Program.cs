/*
Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
void ElementOfArray(int[,] randArray, int number)
{
    string result = "Такого числа нет в массиве";
    int outFor = 0;
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            if (randArray[i, j] == number) 
            {result = $"Вы ввели число {number}. Число находится на позиции Строка № {i+1}, Столбец № {j+1}";
            outFor = 1;
            break;
            }
        } 
        if (outFor == 1){break;}

    }
    Console.WriteLine(result);
}

//прием числа от пользователя
int number(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.WriteLine();
int [,] doubleArray = ArrayGenerator(4, 4, 0, 10);
Console.WriteLine("Создаем рандомный массив");
PrintDoubleArray(doubleArray);
int num = number("Введите число из массива"); 
Console.WriteLine();
ElementOfArray(doubleArray, num);
