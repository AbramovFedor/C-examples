System.Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());

System.Console.Write("Введите число второе: ");
int secondNum = int.Parse(Console.ReadLine());

System.Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine());

if (firstNum > secondNum && firstNum > third){
    System.Console.WriteLine("Самое большое число: ", firstNum);
    System.Console.WriteLine(firstNum);
}

else if (secondNum > firstNum && secondNum > third){
    System.Console.WriteLine("Самое большое число: ", secondNum);
    System.Console.WriteLine(secondNum);
}
else if (third > firstNum && third > secondNum){
    System.Console.WriteLine("Самое большое число: ");
    System.Console.WriteLine(third);
}
