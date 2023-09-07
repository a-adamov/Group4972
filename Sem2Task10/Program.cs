// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Инструмент отладки для проверки времени исполнения кода
using System.Diagnostics;
Stopwatch stopwatch = Stopwatch.StartNew();

// Метод для получения числа
int getNum()
{
    Console.WriteLine("Введите трехзначное число");
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Способ 1

void var1()
{
    stopwatch.Start(); // запустили счетчик

    Console.WriteLine("Способ 1");
    int number = getNum();

    if (number > 99 && number < 1000) // проверка на правильность ввода данных
    {
        char[] digitChar = number.ToString().ToCharArray(); // разложение числа на массив из char
        Console.WriteLine("Второе число: " + digitChar[1]);
    }
    else
    {
        Console.WriteLine("Ошибка ввода данных");
    }

    stopwatch.Stop(); // остановили счетчик
    Console.WriteLine("Время исполнения кода: " + stopwatch.ElapsedMilliseconds + "мс"); // вывели время на выполнение
    stopwatch.Reset(); //сбросили счётчик
}

// Способ 2

void var2()
{
    stopwatch.Start(); // запустили счетчик

    Console.WriteLine("Способ 2");
    int number1 = getNum();

    if (number1 > 99 && number1 < 1000) // проверка на правильность ввода данных
    {
        Console.WriteLine("Второе число: " + ((number1 % 100) / 10)); // получаем количество десяток во втором разряде
    }
    else
    {
        Console.WriteLine("Ошибка ввода данных");
    }

    stopwatch.Stop(); // остановили счетчик
    Console.WriteLine("Время исполнения кода: " + stopwatch.ElapsedMilliseconds + "мс"); // вывели время на выполнение
    stopwatch.Reset(); //сбросили счётчик
}

var1();
var2();