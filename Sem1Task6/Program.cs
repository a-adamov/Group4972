/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите целое число");
string str = Console.ReadLine() ?? "0";
int num = int.Parse(str);

if (num % 2 == 0) 
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

//Альтернативное решение через тернарный оператор

// Console.WriteLine("Введите целое число");
// string str = Console.ReadLine() ?? "0";
// int num = int.Parse(str);
// Console.WriteLine(num%2 == 0 ? "Число четное" : "Число нечетное");