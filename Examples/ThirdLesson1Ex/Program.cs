//Задача 18: Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadQoute(string qoute ){
    System.Console.WriteLine($"Введите номер координатной четверти: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int qoute = ReadQoute("qoute");

string signx = "";

string signy = "";


if (qoute == 1){
   signx = "+";
   signy = "+";
}
else if (qoute ==2){
    signx = "+";
    signy = "-";
}
else if (qoute ==3){
    signx = "-";
    signy = "-";
}
else if (qoute ==4){
    signx = "-";
    signy = "+";
}

System.Console.WriteLine($"Координата Х в четверти {qoute} лежат в пределах от 0 до {signx} ∞");

System.Console.WriteLine($"Координата Y в четверти {qoute} лежат в пределах от 0 до {signy} ∞");