/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
*/

int [] numbers = CreateArray();
PrintArray(numbers);
SumOfNotEven(numbers);

int [] CreateArray(){
    int a = new Random().Next(1,10);
    int [] numbers = new int[a];

    for (int i = 0; i < numbers.Length; i++){
        numbers[i] = new Random().Next(1,10);
    }
    return numbers;
}

void SumOfNotEven(int[] numbers){
    int i = 0;
    int negative = 0;
    while (i < numbers.Length){
        if (numbers[i] % 2 == 0){
            i++;
        }else{
            negative += numbers[i];
            i++;
        }
    }System.Console.WriteLine($"Сумма нечетных чисел в массиве равна: {negative}");

}

void PrintArray(int[] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++){
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

