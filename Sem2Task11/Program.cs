// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Способ 1

void var1()
{
    Console.WriteLine("Способ 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();
    Console.WriteLine(digitChar[0].ToString()+digitChar[2].ToString());
}

// Способ 2

void var2()
{
    Console.WriteLine("Способ 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    Console.Write(number/100);
    Console.Write(number%10);
}

var1();
var2();