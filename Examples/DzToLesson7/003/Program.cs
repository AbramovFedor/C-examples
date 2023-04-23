/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void ArithmeticMean(int[,] array)
{
    //int b = 0;
    double a = 0;
    for (int i = 0; i <= array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            a = a + array[i, j];
        }System.Console.Write($"\n a = {a} {a / 4}");
        i++;
    }
}

*/


int [,] array = CreateArray(3, 4);
PrintArray(array);
ArithmeticMean(array);


int[,] CreateArray(int length1, int lenght2)
{
    int[,] array = new int[length1, lenght2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            System.Console.Write(array[i, j] + " ");

        }
        System.Console.WriteLine();
    }
}


double ArithmeticMean(int[,] array)
{
    int i = 0;
    int j = 0;
    double a = 0;
    while (j <= array.GetLength(0))
    {
        a = a + array[i, j];
        j++;
    }
    System.Console.WriteLine($"\n {a / 4}");
    return a;
}