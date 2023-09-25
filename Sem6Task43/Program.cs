// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// (Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых

// Метод чтения данных
double[] ReadKoef(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine();
    double[] line = str.Split(' ').Select(double.Parse).ToArray();

    return line;
}

// Метод нахождения точки пересечения прямых
double[] FindCrossPoint(double[] line1, double[] line2)
{
    double[] point = new double[2];
    double x = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    double y = line1[0] * x + line1[1];
    point[0] = x;
    point[1] = y;
    return point;
}

// Метод нахождения расстояния между двумя точками
double FindDistance(double[] point1, double[] point2)
{
    double dist = Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2));
    return dist;
}

// Метод нахождения площади треугольника по формуле Герона
double TriangleSquare(double[] line1, double[] line2, double[] line3)
{
    double[] point1 = FindCrossPoint(line1, line2);
    double[] point2 = FindCrossPoint(line1, line3);
    double[] point3 = FindCrossPoint(line2, line3);

    double a = FindDistance(point1, point2);
    double b = FindDistance(point1, point3);
    double c = FindDistance(point2, point3);

    double p = (a + b + c) / 2;
    double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    return square;
}


double[] line1 = ReadKoef("Введите коэффициетны k и b для первой прямой через пробел:");
double[] line2 = ReadKoef("Введите коэффициетны k и b для второй прямой через пробел:");
double[] line3 = ReadKoef("Введите коэффициетны k и b для третьей прямой через пробел:");
double square = TriangleSquare(line1, line2, line3);
Console.WriteLine("Площадь треугольника, образованного прямыми, равна " + square);