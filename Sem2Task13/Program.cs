// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

// Метод для получения числа
long getNum()
{
    Console.WriteLine("Введите целое число");
    long num = long.Parse(Console.ReadLine() ?? "0");
    return num;
}

long number = getNum();
int capacity = (int)Math.Floor(Math.Log10(Math.Abs(number))) + 1; // определяем разрядность числа

if (capacity > 10) //проверяем разряднось
{
    Console.WriteLine("Вы ввели число разрядности больше 10");
}
else if (capacity > 2)
{
    long cutNumber = Math.Abs(number % ((long)Math.Pow(10, (capacity - 2)))); // отбрасываем последние 2 разряда
    Console.WriteLine("Третье число: " + (cutNumber / (long)Math.Pow(10, (capacity - 3)))); // оставляем только первую цифру (последний разряд)
}
else
{
    Console.WriteLine("Вы ввели число разрядности меньше 3");
}