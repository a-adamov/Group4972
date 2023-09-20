// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4;
//  массив [6, 7, 19, 345, 3] -> нет-3; массив [6, 7, 19, 345, 3] -> да

// Генерируем массив
int[] GenArray(int len, int lowBorder, int highBorder)
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(lowBorder, highBorder + 1);
    }
    return array;
}

// Выводим результат
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

// Метод поиска элемента
int FindElement(int[] arr, int elem)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            return i;
        }

    }
    return -1;
}

// Метод для ввода данных
int GetNum(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] array = GenArray(12, -9, 9);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
int elem = GetNum("Введите искомый элемент: ");
int index = FindElement(array, elem);
Console.WriteLine(index == -1 ? "Элемент не найден" : "Индек элемента: " + index);