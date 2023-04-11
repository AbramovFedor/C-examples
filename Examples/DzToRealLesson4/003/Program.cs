//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray()
{
int [] numbers = new int [8];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,10);
}
return numbers;
}

void PrintArray(int [] numbers){
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++){
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}


int [] numbers = CreateArray();
PrintArray(numbers);