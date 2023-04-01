// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int WeekDay(){
    System.Console.WriteLine("Введите номер дня недели: ");
    int a = int.Parse(System.Console.ReadLine());
    return a;
}

int NumDay = WeekDay();

if (NumDay <= 5){
    System.Console.WriteLine("Не выходной");
}else if(NumDay < 8 && NumDay > 5){
    System.Console.WriteLine("Выходной!");
}else{
    System.Console.WriteLine("В неделе только семь дней!");
}