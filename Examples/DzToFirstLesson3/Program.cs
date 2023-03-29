// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) {
    System.Console.Write(number);
    System.Console.WriteLine(" четное число");
}else{
    System.Console.Write(number);
    System.Console.WriteLine(" не четное число");
}