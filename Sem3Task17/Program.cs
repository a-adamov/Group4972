// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Проверяем четверть по координатам
int QuoterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x > 0 && y < 0) return 3;
    if (x < 0 && y < 0) return 4;
    return 0;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");

int res = QuoterTest(x, y);

PrintResult("Номер четверти " + res);