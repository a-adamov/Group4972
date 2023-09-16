// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

// Инструмент отладки для проверки времени исполнения кода
using System.Diagnostics;
Stopwatch stopwatch = Stopwatch.StartNew();

// Вводим данные
int GetNum(string msg)
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

// Раскладываем число на массив из цифр
char[] NumToArray(int num)
{
    char[] digitChar = num.ToString().ToCharArray();
    return digitChar;
}

// Считаем сумму элементов массива
int GetSumDigits1(int num)
{
    char[] digitChar = NumToArray(num);
    int sum = 0;
    for (int i = 0; i < digitChar.Length; i++)
    {
        int digit = int.Parse(digitChar[i].ToString());
        sum += digit;
    }
    return sum;
}

// Считаем сумму цифр через остаток от деления
int GetSumDigits2(int num)
{
    int sum = 0;
    while (num % 10 > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int num = GetNum("Введите целое число:");
int sum1 = GetSumDigits1(num);
int sum2 = GetSumDigits2(num);

stopwatch.Start(); // запустили счетчик
PrintResult("Способ 1");
PrintResult("Сумма цифр в числе " + num + " равна " + sum1);
stopwatch.Stop(); // остановили счетчик
Console.WriteLine("Время исполнения кода: " + stopwatch.ElapsedMilliseconds + " мс"); // вывели время на выполнение
stopwatch.Reset(); //сбросили счётчик

stopwatch.Start(); // запустили счетчик
PrintResult("Способ 2");
PrintResult("Сумма цифр в числе " + num + " равна " + sum2);
stopwatch.Stop(); // остановили счетчик
Console.WriteLine("Время исполнения кода: " + stopwatch.ElapsedMilliseconds + " мс"); // вывели время на выполнение
stopwatch.Reset(); //сбросили счётчик