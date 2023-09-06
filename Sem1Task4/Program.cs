/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine() ?? "0";

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine() ?? "0";

Console.WriteLine("Введите третье число");
string num3 = Console.ReadLine() ?? "0";

int a = int.Parse(num1);
int b = int.Parse(num2);
int c = int.Parse(num3);

int max = a;

if (b > a)
{
    max = b;
}

if (c > b)
{
    max = c;
}

Console.Write("Максимальное число ");
Console.Write(max);
