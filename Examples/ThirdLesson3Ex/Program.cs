//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int ReadNumber(){
    System.Console.Write($"Введите число: ");
    int a = int.Parse(System.Console.ReadLine());
    return a;
}

int N = ReadNumber();

double I = 0;

void Sqrt(int N){


    for(int i = 1; i <= N; i++){

        I = Math.Pow(i, 2);
        System.Console.WriteLine(I);
    }

}

Sqrt(N);