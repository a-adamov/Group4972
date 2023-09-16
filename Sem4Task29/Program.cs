// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

// (задание со *) Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

// // Вводим данные
// int GetNum(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Выводим результат
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// // Генерируем массив
// int[] GenArray(int len, int border1, int border2)
// {
//     Random rnd = new Random();
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = rnd.Next(border1, border2 + 1);
//     }
//     return array;
// }

// int len = GetNum("Введите длину массива: ");
// int border1 = GetNum("Введите нижнюю границу диапазона значения числа в массиве: ");
// int border2 = GetNum("Введите верхнюю границу диапазона значения числа в массиве: ");
// int[] array = GenArray(len, border1, border2);
// PrintArray(array);



// Задача *

// Вводим данные
string GetStr(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine();
    return str;
}

// Преобразуем строку в массив
string[] GetArray(string str)
{
    string[] arr = str.Split(",");
    return arr;
}

// Проверяем правильность ввода и выбираем случайное имя из массива
string GetRandomName(string names)
{
    if (names.Contains(","))
    {
        string[] namesArray = GetArray(names);
        Random rnd = new Random();
        string randName = namesArray[rnd.Next(0, namesArray.Length - 1)];
        return randName;
    }
    else
    {
        return "сначала правильно введите список имен";
    }
}

string nameList = GetStr("Введите имена кандитатов через запятую: ");
string lucky = GetRandomName(nameList);
PrintResult("Сегодня посуду моет...... " + lucky + "!!!");
