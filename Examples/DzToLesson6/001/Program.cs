/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2*/
int lenght = Numbers("Введте количество элементов >");
int[] array;
array = InputArray(lenght);
PrintArray(array);
System.Console.WriteLine($"Количество чисел болше 0 = {CountPositiveNumbers(array)}");


int Numbers(string message){
    System.Console.WriteLine(message);
    string value = System.Console.ReadLine();
    int chenge = Convert.ToInt32(value);
    return chenge;
}

int[] InputArray(int lenght){
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++){
        array[i] = Numbers($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0){
            count++;
        }
    }
    return count;
}