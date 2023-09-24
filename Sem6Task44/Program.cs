// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

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

// Метод перевода десятичного числа в двоичное
void PrintFibNum(int num)
{
    int boofer = 0;
    int firstNum = 0;
    int secondNum = 1;
    Console.Write(firstNum + "_" secondNum);
    for (int i=2; i<num;i++)
    {
        Console.Write()
    }
    return bin;
}

int num = ReadData("Введите целое число: ");
string bin = DecToBin(num);
PrintResult("Двоичное представление: " + bin);