//Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 2D пространстве.

double ReadQoute(string qoute ){
    System.Console.WriteLine($"Введите номер: {qoute}");
    double x = double.Parse(System.Console.ReadLine());
    return x;
}

double x1 = ReadQoute("x1");

double y1 = ReadQoute("y1");

double x2 = ReadQoute("x2");

double y2 = ReadQoute("y2");

double Sqrt(double x1, double y1, double x2, double y2){

    double C1 = Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)), 2);

    return C1;

}

double C1 = Sqrt(x1, y1, x2, y2);

System.Console.WriteLine(C1);
