//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double ReadQoute(string qoute ){
    System.Console.Write($"Введите номер {qoute}: ");
    double x = double.Parse(System.Console.ReadLine());
    return x;
}

double x1 = ReadQoute("x1");

double y1 = ReadQoute("y1");

double z1 = ReadQoute("z1");

double x2 = ReadQoute("x2");

double y2 = ReadQoute("y2");

double z2 = ReadQoute("z2");

double Sqrt(double x1, double y1, double z1, double x2, double y2, double z2){

    double C1 = Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)), 2);

    return C1;

}

double C1 = Sqrt(x1, y1, z1, x2, y2, z2);

System.Console.WriteLine($"Координаты точки: {C1}");
