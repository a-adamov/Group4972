// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Метод для проверки треугольника
bool TriangleTest(int a, int b, int c)
{
    return (a+b>c && a+c>b && b+c>a);
}

int a = ReadData("Введите первую сторону треугольника: ");
int b = ReadData("Введите первую вторую треугольника: ");
int c = ReadData("Введите первую третью треугольника: ");

PrintResult(TriangleTest(a, b, c) ? "Треугольник существует" : "Треугольник не существует");





