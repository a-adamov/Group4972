// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5

// Вводим данные
int ReadData(string msg)
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

// Считаем цифры
int CountDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

int num = ReadData("Введите целое число: ");
int count = CountDigit(num);
PrintResult("Количество цифр в числе " + num + " равно " + count);