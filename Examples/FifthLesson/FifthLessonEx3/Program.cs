
int CreateArray(){
    System.Console.Write("Введите длину массива: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int[] Array = new int[CreateArray()];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,51);
    System.Console.WriteLine(Array[i]);
}

int FaindNumb(){
    System.Console.Write("Введите искомое число: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int a = FaindNumb();

for (int i = 0; i < Array.Length; i++)
{

    if (Array[i] == a)
    {
        System.Console.WriteLine($"{a} присутствует в массиве.");
        break;
    } if (i == Array.Length-1){
    System.Console.WriteLine($"Числа {a} нет в массиве.");
}
}