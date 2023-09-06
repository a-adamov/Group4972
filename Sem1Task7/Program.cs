// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > 100 && num < 1000)
{
    int LastDigit = num % 10;
    Console.WriteLine("Последння цифра числа " + num + " это " + LastDigit);
}
else
{
    Console.WriteLine("Число не трехзначное");
}

//Альтернативное решение через тернарный оператор
// Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");