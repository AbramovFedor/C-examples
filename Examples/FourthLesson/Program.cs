//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int a = Number();

int result = Mult(a);

int Number(){
    System.Console.Write("Введите число: ");
    int a = int.Parse(System.Console.ReadLine());
    return a;
}

int Mult(int a){
    int result = 1;
    for (int i = 1; i <= a; i++){
        result = i * result;
    }
    return result;
}


System.Console.WriteLine($"Произведением чисел от 1 до {a} будет {result}");