/*Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"*/

System.Console.Write("Ведите число: ");
int number = int.Parse(System.Console.ReadLine()!);

ShowNumbers(number);

void ShowNumbers(int number)
{
    if (number > 0)
    {
        System.Console.Write(number);
        if (number != 1)
        {
            System.Console.Write(", ");
        }
        ShowNumbers(number -1);
    }
}

