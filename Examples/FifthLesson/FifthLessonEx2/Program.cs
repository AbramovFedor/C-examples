/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

int[] PositArray = new int[4] ;


    for (int i = 0; i < PositArray.Length; i++)
    {
        PositArray[i] = new Random().Next(-10,10);
        System.Console.WriteLine(PositArray[i]);
    }

System.Console.WriteLine("");

DoubleArray(PositArray);

void DoubleArray(int[] Array){

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] *= -1 ;
        System.Console.WriteLine(Array[i]);
    }
}
