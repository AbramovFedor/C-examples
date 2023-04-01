//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNum(){
    System.Console.Write("Введите число: ");
    int n = int.Parse(System.Console.ReadLine());
    return n;
}

int N = ThirdNum(); 

if (99 < N && N < 1000){

int n = N % 10;

System.Console.WriteLine(n);

}else if (999 < N && N < 10000){

    int n = N % 10;
    int Num = N - n;
    int Numers = (Num % 100) / 10;

    System.Console.WriteLine(Numers);
    
}else if (9999 < N && N < 100000){

   int n = N % 100;
    int Num = (N - n) / 100;
    int Numers = (Num % 100) % 10;

    System.Console.WriteLine(Numers);
}else if(N > 100000){
    System.Console.WriteLine("Это число слишком большое, введите число поменьше.");
}else{
    System.Console.WriteLine("У заданного числа нет третьей цифры!");
}
