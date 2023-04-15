//Перевернуть одномерный массив.

int Length = ReadInt("длину массива");
int min = ReadInt("минимальное значение массива");
int max = ReadInt("максимальное значение массива");
int [] numbers = CreateArray(Length, min, max);
PrintArray(numbers);
Reverse(numbers);
PrintArray(numbers);

int ReadInt(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

int [] CreateArray(int Length, int min, int max)
{
    int [] numbers = new int [Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);
    }
    return numbers;
}

void Reverse(int[] numbers)
{
    for (int i = 0; i < numbers.Length/2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[numbers.Length-1-i];
        numbers[numbers.Length-1-i] = temp;
    }
}

void PrintArray(int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length-1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length-1]+ "]");
}


// int Length = ReadInt("длину массива");
// int min = ReadInt("минимальное значение массива");
// int max = ReadInt("максимальное значение массива");
// int [] numbers = CreateArray(Length, min, max);
// Print(numbers);
// Reverse(numbers);
// Print(numbers);


// int ReadInt(string arg){
//     System.Console.Write($"Введите {arg}: ");
//     return int.Parse(System.Console.ReadLine());
// }

// int [] CreateArray(int Length, int min, int max){
//     int [] numbers = new int [Length];

//     for (int i = 0; i < numbers.Length; i++){
//         numbers[i] = new Random().Next(min, max);
//     }
//     return numbers;
// }

// void Reverse(int [] numbers){
//     for (int i = 0; i < numbers.Length / 2; i++){
//         int temp = numbers[i];
//         numbers[i] = numbers[numbers.Length-1 - i];
//         numbers[numbers.Length-1] = temp;
//     }
// }

// void Print(int [] numbers){
//     System.Console.Write("[");
//     for (int i = 0; i < numbers.Length-1; i++){
//         System.Console.Write(numbers[i] + "; ");
//     }
//     System.Console.WriteLine(numbers[numbers.Length-1]+ "]");
// }
