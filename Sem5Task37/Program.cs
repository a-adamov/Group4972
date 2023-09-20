// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 12 10

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

// Метод конвертации массива
int[] ConvertElement(int[] arr)
{
    int[] outArray = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        outArray[i] = arr[i] * arr[arr.Length-1 - i];
    }
    return outArray;
}

int[] array = GenArray(10, 0, 10);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
int[] outArray = ConvertElement(array);
Console.WriteLine("Конвертированный массив: ");
PrintArray(outArray);