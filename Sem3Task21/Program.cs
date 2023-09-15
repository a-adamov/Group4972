// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Считаем расстояние
double CalcDist(int x1, int y1, int x2, int y2)
{
   double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
   return dist;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");

double res = CalcDist(x1, y1, x2, y2);

PrintResult("Расстояние между точками: " + res);