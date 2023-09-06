// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine() ?? "0");

if (numB * numB == numA)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

//Альтернативный вариант через тернарный оператор
// Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");