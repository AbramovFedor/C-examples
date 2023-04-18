/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int [] numbers = CreateArray();
PrintArray(numbers);
FindDiff(numbers);

int [] CreateArray(){
    int a = new Random().Next(1,10);
    int [] numbers = new int[a];

    for (int i = 0; i < numbers.Length; i++){
        numbers[i] = new Random().Next(1,10);
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

void FindDiff(int[] numers){
    int i = 0;
    //int b = 0;
    //int max = 0;
    while (i < numers.Length){
        for ( int max = 0; max > numers[i]; i++){
            max = numers[i];
            i++;
            System.Console.WriteLine($"max = {max}");
        }
        i++;
    }
}
