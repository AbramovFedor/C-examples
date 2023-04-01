//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int AllTwoNumbers(){

    System.Console.Write("Введите число: ");
    int numb = int.Parse(System.Console.ReadLine());
    return numb;

}

int Num = AllTwoNumbers();

while(Num != 0){

    if (Num % 2 == 0) {
        System.Console.Write($"{Num} ");
        //System.Console.WriteLine(" четное число");
        Num--;
    }else{
        Num--;
    }

}