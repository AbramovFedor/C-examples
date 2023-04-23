/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int [,] array = CreateArray(3,3);
PrintArray(array);
LookinngForNumber(array);

int[,] CreateArray(int length1, int lenght2)
{
    int[,] array = new int[length1, lenght2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
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
            System.Console.Write(array[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
}

void LookinngForNumber(int[,] array)
{
    int i = 0;
    int j = 0;
    System.Console.Write("Write a number: ");
    int TheNumber = int.Parse(System.Console.ReadLine());
    while (i < array.GetLength(0))
    {
        if (TheNumber == array[i,j])
        {
            System.Console.WriteLine($"Yes, {TheNumber} in array.");
            j++;
            i++;
        }else
        {
            System.Console.WriteLine($"Don\'t have a {TheNumber} in array.");
            i++;
            j++;
        }
        i++;
    }
}
