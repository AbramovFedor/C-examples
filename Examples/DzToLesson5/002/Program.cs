/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19*/

int [] numbers = CreateArray();
PrintArray(numbers);

int [] CreateArray(){
    int a = new Random().Next(1,10);
    int [] numbers = new int[a];
    System.Console.WriteLine(a);

    for (int i = 0; i < numbers.Length; i++){
        numbers[i] = new Random().Next(100,1000);
    }
    return numbers;
}

void PrintArray(int[] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++){
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}
