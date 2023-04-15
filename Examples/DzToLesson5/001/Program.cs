/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int [] numbers = CreateArray();
PrintArray(numbers);
FindPositive(numbers);

int [] CreateArray(){
    int a = new Random().Next(1,10);
    int [] numbers = new int[a];

    for (int i = 0; i < numbers.Length; i++){
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;
}

void FindPositive(int[] numbers){
    int i = 0;
    int positive = 0;
    int negative = 0;
    while (i < numbers.Length){
        if (numbers[i] % 2 == 0){
            i++;
            positive++;
        }else{
            i++;
            negative++;
        }
    }System.Console.WriteLine($"Четных чисел в массиве: {positive}");

}

void PrintArray(int[] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++){
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

