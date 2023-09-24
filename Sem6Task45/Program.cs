// Задача №45
// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

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

// Метод вывода массива чисел на экран
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

// Метод копирования массива
int[] CopyArray(int[] arr)
{
    int[] outArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArray[i] = arr[i];
    }
    return outArray;
}

int[] array = GenArray(10, 0, 9);
PrintArray(array);
int[] copyArray = CopyArray(array);
PrintArray(copyArray);