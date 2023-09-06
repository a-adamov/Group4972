/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine() ?? "0");
int even = 2;

while (even < num)
{
    Console.Write(even % 2 == 0 ? even : ", ");
    even++;
}

Console.Write(num % 2 == 0 ? num : "");
