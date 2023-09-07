// Задача №9
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Способ 1

void var1()
{
    Console.WriteLine("Способ 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

// Способ 2

void var2()
{
    Console.WriteLine("Способ 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    Console.WriteLine(number / 10 > number % 10 ? (int)(number / 10) : (int)(number % 10));
}

// Способ 3

void var3()
{
    Console.WriteLine("Способ 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();
    Console.WriteLine(digitChar[0] > digitChar[1] ? digitChar[0] : digitChar[1]);
}

var1();
var2();
var3();