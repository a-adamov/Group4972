/*Задача №0
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).*/

Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine();//??"0"(проверка на null)

if (inputNum != null)
{
    // int num = int.Parse(inputNum);
    // int res = num*num;
    // Console.WriteLine(res);
    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}