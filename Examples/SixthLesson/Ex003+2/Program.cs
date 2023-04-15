// Напишите программу, которая будет преобразовывать десятичное число в шестнадцатиричное.


int a = ReadInt("положительное число");
Sixteen(a);

int ReadInt(string argument){
    int number;
    System.Console.WriteLine($"Введите {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) && number > 0){
        System.Console.WriteLine("Это не число.");
    }
    return number;
}

void Sixteen(int number){
    string line = string.Empty;
    while(number > 0){
        int result = number % 16;
        switch (result){
            case 10: line = line + "A"; break;
            case 11: line = line + "B"; break;
            case 12: line = line + "C"; break;
            case 13: line = line + "D"; break;
            case 14: line = line + "E"; break;
            case 15: line = line + "F"; break;
            default: line = line + number % 16; break;
        }
        number /= 16;
    }
    string temp = string.Empty;
    for (int i = 0; i < line.Length; i++){
        temp += line[line.Length - 1 - i];
    }
    System.Console.WriteLine(temp);
}