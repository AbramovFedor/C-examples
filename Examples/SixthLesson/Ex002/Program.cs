

int a = ReadInt("Длина стороны A: ");
int b = ReadInt("Длина стороны B: ");
int c = ReadInt("Длина стороны C: ");
Treangle(a, b, c);


int ReadInt(string argument){
    int number;
    System.Console.Write($"{argument}: ");
    while (!int.TryParse(System.Console.ReadLine(), out number) && number > 0){
        System.Console.WriteLine("Wrong");
    }
    return number;
}

void Treangle(int a, int b, int c){
    if (a + b > c && b + c > a && c + a > b){
        System.Console.WriteLine("Треугольник с такими параметрами может существовать");
        
    }else{
        System.Console.WriteLine("Треугольник с такими параметрами не может существовать");
    }
}