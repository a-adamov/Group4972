// Задача 39:Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый -на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]

// Метод генерации массива
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

// Метод вывода массива на экран
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
    Console.WriteLine();
}

// Метод разворота массива созданием нового
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

// Метод разворота существующего массива
void SwapArray(int[] arr)
{
    int bufer = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufer = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = bufer;
    }
}

int[] array = GenArray(10, 0, 9);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Перевернутый массив:");
int[] swapArr = SwapNewArray(array);
PrintArray(swapArr);

SwapArray(array);
Console.WriteLine("Перевернутый исходный массив:");
PrintArray(array);

