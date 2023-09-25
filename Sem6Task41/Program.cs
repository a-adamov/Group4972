// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Подключаем библиотеку для работы с рег. выражениями
using System.Text.RegularExpressions;

// Метод чтения строки ограниченной длины
string ReadLimitStr(string msg, int limit)
{
    Console.WriteLine(msg);
    string str = string.Empty;
    int len = 0;
    while (len < limit) // записываем в строку все символы до достижения лимита
    {
        // Неработающая проверка на ввод символов меньше установленного лимита
        // if (Console.ReadKey().Key == ConsoleKey.Enter)
        // {
        //     Console.WriteLine($"Вы ввели меньше {limit} символов");
        //     break;
        // }
        str += Console.ReadKey().KeyChar;
        len++;
    }
    return str;
}

// Метод поиска положительных чисел в строке
int CoutnPosNum (string str)
{
    int allNumbers = Regex.Matches(str, @"\d+").Count; // находим все числа в строке
    int negNumbers = Regex.Matches(str, @"\-\d+").Count; // находим все отрицательные числа в строке
    int posNumbers = allNumbers - negNumbers; // находим все положительные числа
    return posNumbers;
}

string str = ReadLimitStr("Введите 10 символов", 15);
int posNumbers = CoutnPosNum(str);
Console.WriteLine("Кол-во положительных чисел: " + posNumbers);
