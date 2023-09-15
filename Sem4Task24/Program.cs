// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. 7 -> 28 4 -> 10 8 -> 36

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

// Считаем сумму
int CalcSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

// Считаем сумму по формуле Гаусса
int CalcGaussSum(int num)
{
    return num * (num+1)/2;
}

int num = ReadData("Введите целое число: ");

DateTime d1 = DateTime.Now;
int sum1 = CalcSum(num);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int sum2 = CalcGaussSum(num);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма целых чисел от 1 до " + num + " (метод перебора): " + sum1);
PrintResult("Сумма целых чисел от 1 до " + num + " (аналитический метод): " + sum2);