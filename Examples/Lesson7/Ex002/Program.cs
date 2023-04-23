//Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

PrintArray(CreatArray(3, 4));

int [,] CreatArray(int length1, int length2)
{
int [,] array = new int [length1, length2];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i,j] = i + j;
}
}
return array;
}

void PrintArray(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
System.Console.Write(array[i,j] + " ");
}
System.Console.WriteLine();
}

}