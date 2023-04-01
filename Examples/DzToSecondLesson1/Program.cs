//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
int MyNum(){

    System.Console.Write("Введите трехзначное число: ");
    int n = int.Parse(System.Console.ReadLine());
    return n;

}

int N = MyNum();

int n = N % 10;
int Num = N - n;
int Numers = (Num % 100) / 10;

System.Console.WriteLine(Numers);