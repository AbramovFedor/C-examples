/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int a = ReadNumb();
int b = ReadNumb();

int ReadNumb(){
    System.Console.Write($"Введите число: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

System.Console.Write($"Квадрат числа {a} в степени {b}: ");
System.Console.WriteLine(Math.Pow(a,b));