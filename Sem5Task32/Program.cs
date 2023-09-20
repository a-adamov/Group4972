// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//  [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

// Метод инвертирования массива
void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}

int[] array = GenArray(12, -9, 9);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
InverseArray(array);
Console.WriteLine("Инвертированный массив: ");
PrintArray(array);