int CreateArray(){
    System.Console.Write("Введите длину массива: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int[] Array = new int[CreateArray()];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-100,201);
    System.Console.Write($"{Array[i]}; ");
}

void Task(int[] Array){

    int count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= 10 && Array[i] <= 99){
            count++;
        }
    }

System.Console.WriteLine(count);

}
System.Console.WriteLine(" ");
Task(Array);