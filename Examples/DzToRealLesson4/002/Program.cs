/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10*/

int MyNumb = ReadNumb();
int a = MyNumb;
int x = 0;
int b = 0;

int ReadNumb(){
    System.Console.Write($"Введите число: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

for (int i = -10; i <= a; i++){
    b = a % 10;
    a /= 10;
    x += b;
}

System.Console.WriteLine($"Сумма цифр числа {MyNumb} равна: {x}");