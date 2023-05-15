// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120


System.Console.WriteLine("Введите два числа:");
int n = int.Parse(System.Console.ReadLine()!);
int SecN = int.Parse(System.Console.ReadLine()!);
int num = 0;

CoutnNumbers();

void CoutnNumbers()
{
    for (int i = n; i - 1 < SecN; i++)
    {
        num = num + n;
        n++;
    }System.Console.WriteLine($"Ответ: {num}");
    
}