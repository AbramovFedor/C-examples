// Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.

int[,] CreateArray(int length1, int lenght2)
{
    int[,] Array = new int[length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 10);
        }
    }
    return Array;

}

    void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i, j] + "\t");

        }
        System.Console.WriteLine();
    }
} 
int [,] array=CreateArray(3,3);

PrintArray(array);
void ChancheString(int [,] array)
{



    for (int j = 0; j < array.GetLength(1); j++)
    {
       int temp = array [0,j];
       array [0, j] = array[array.GetLength(0)-1,j];
       array[array.GetLength(0)-1, j] = temp;
    }

System.Console.WriteLine();
}
ChancheString(array);
PrintArray(array);