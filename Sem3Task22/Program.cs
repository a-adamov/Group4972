// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Формируем таблицу степеней
string BuildPowTable(int num, int pow)
{
    string res = string.Empty;

    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + "     ";
    }

    return res;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите целое число: ");
int pow = ReadData("Введите степень: ");
string head = BuildPowTable(num, 1);
string res = BuildPowTable(num, pow);
PrintResult("Таблица степеней: ");
PrintResult(head);
PrintResult(res);

