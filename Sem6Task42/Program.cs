// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

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
string DecToBin(int num)
{
    string bin = string.Empty;
    while(num>0)
    {
        bin = num%2 + bin;
        num /= 2;
    }
    return bin;
}

int num = ReadData("Введите целое число: ");
string bin = DecToBin(num);
PrintResult("Двоичное представление: " + bin);