﻿//------------------------------------------------------------------------------------------------------------------
// Задача 70: Программа принимает числа A и B и возводит число A в степень B.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

// Считываем даннные
int numA = ReadData("Введите основание:");
int numB = ReadData("Введите степень:");

// Возводим в степень
long res1 = RecPow(numA, numB);
long res2 = MyPow(numA, numB);

// Выводим результат на экран
Console.WriteLine("A в степени B способ 1: " + res1);
Console.WriteLine("A в степени B способ 2: " + res2);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Метод чтения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод возведения в степень
long RecPow(int numA, int numB)
{
    return ((numB > 0) ? (numA * RecPow(numA, numB - 1)) : 1);
}

// Метод возведения в степень с управлением рекурсией
long MyPow(int numA, int numB)
{
    if (numB == 1)
    {
        return numA;
    }
    if (numB == 2)
    {
        return numA * numA;
    }
    if (numB % 2 == 0)
    {
        return MyPow(numA, numB / 2) * MyPow(numA, numB / 2);
    }
    else
    {
        return MyPow(numA, numB / 2) * MyPow(numA, numB / 2 + 1);
    }
}