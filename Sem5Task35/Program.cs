// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5

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

// Метод подсчета элемента
int CountElement(int[] arr, int a, int b)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= a && arr[i] <= b)
        {
            count++;
        }

    }
    return count;
}

int[] array = GenArray(123, 0, 100);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
int count = CountElement(array, 9, 99);
Console.WriteLine("Количеств элементов от 9 до 99 равно " + count);