System.Console.WriteLine("Введите число: ");
int firstNum = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число второе: ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum){

    Console.Write(firstNum);
    System.Console.Write(" больше чем ");
    System.Console.Write(secondNum);
}
else{
    Console.Write(secondNum);
    System.Console.Write(" больше чем ");
    System.Console.Write(firstNum);
}