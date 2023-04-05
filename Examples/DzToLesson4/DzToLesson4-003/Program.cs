//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int a = Number();

int result = Mult(a);

int Number(){
    System.Console.Write("Введите число: ");
    int a = int.Parse(System.Console.ReadLine());
    return a;
}

int Mult(int a){
    int b = 1;
    int result = a - a + 1;
    for (int i = 1; i <= a; i++){
        result = b * b * b;
        System.Console.WriteLine(result);
        result++;
        b++;
    }
    return result;
}
