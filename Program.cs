

//Home Work 7



//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] CreateRandomArray()
{
    Console.WriteLine("Введите количество строк массива");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение элементов массива");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение элементов массива");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
        }
        
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
double[,] array = CreateRandomArray();
PrintArray(array);
*/




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет

/*
int[,] CreateRandomArray()
{
    Console.WriteLine("Введите количество строк массива");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение элементов массива");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение элементов массива");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void CheckNumberInArray(int[,] array, int positionX, int positionY)
{
    if (positionX < array.GetLength(0) && positionY < array.GetLength(1))
        Console.WriteLine(array[positionX,positionY]);
    else
        Console.WriteLine("Чисел с такими индексами в массиве нет");
}
int[,] array = CreateRandomArray();
Console.WriteLine("Введите первый индекс элемента");
int positionX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс элемента");
int positionY = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
CheckNumberInArray(array, positionX, positionY);
*/



//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] CreateRandomArray()
{
    Console.WriteLine("Введите количество строк массива");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение элементов массива");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение элементов массива");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return array;
}
void PrintArrayB2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
double[] SearchArithmeticMean(int[,] array)
{
    double[] arithMean = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp = temp + array[i, j];
        }
        arithMean[j] = temp / array.GetLength(0);
        temp = 0;
    }
    return arithMean;
}
void PrintArrayA1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[,] array = CreateRandomArray();
PrintArrayB2(array);
double[] arithMean = SearchArithmeticMean(array);
Console.WriteLine();
PrintArrayA1(arithMean);
*/




