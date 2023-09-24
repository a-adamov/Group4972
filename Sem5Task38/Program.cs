// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.

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

// Метод генерации массива вещественных чисел
double[] GenArrayDouble(int len, int lowBorder, int highBorder)
{
    Random rnd = new Random();
    double[] array = new double[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(lowBorder, highBorder + 1) + Math.Round(rnd.NextDouble(), 2);
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

// Метод вывода массива вещественных чисел на экран
void PrintArrayDouble(double[] array)
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

// Метод расчета разницы между макс и мин
double MaxMinDiff(double[] arr)
{
    return arr.Max() - arr.Min();
}

// Метод сортировки вставкой
int[] InputSort(int[] arr)
{
    int[] sortedArray = new int[arr.Length]; // создаем массив с длинной исходного массива
    sortedArray[0] = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i;
        sortedArray[j] = arr[i]; // поочередно добавляем в новый массив элементы исходного массива
        while (j > 0 && sortedArray[j] < sortedArray[j-1]) // сравниваем элементы исходного массива и нового и переставляем элементы
        {
            int temp = sortedArray[j];
            sortedArray[j] = sortedArray[j-1];
            sortedArray[j-1] = temp;
            j--;
        }
    }
    arr = sortedArray;
    return arr;
}

// Метод сортировки подсчетом для целых чисел
int[] CountSort(int[] arr)
{
    int[] countDigitArray = new int[arr.Max() - arr.Min() + 1]; // создаем массив с длинной диапазона целых чисел в исходном массиве
    int shift = arr.Min(); // смещение начачла диапазона чисел относительно нуля

    for (int i = 0; i < countDigitArray.Length; i++) // заполняем массив нулями
    {
        countDigitArray[i] = 0;
    }

    for (int i = 0; i < countDigitArray.Length; i++) // считаем количество каждого значения диапазона в исходном массиве
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == i + shift) countDigitArray[i]++;
        }
    }

    int index = 0;
    for (int i = 0; i < countDigitArray.Length; i++) // переписываем исходный массив
    {
        for (int k = 0; k < countDigitArray[i]; k++) // по поряднку записываем каждое значение стколько раз, сколько оно встретилос в исходном массиве
        {
            arr[index] = i + shift;
            index++;
        }
    }
    return arr;
}

double[] array = GenArrayDouble(10, 0, 9);
Console.WriteLine("Массив: ");
PrintArrayDouble(array);
double diff = MaxMinDiff(array);
Console.WriteLine("Разница между максимальным и минимальным элементом: " + diff);

int[] array1 = GenArray(10, 0, 9);
Console.WriteLine("Массив: ");
PrintArray(array1);
array1 = InputSort(array1);
Console.WriteLine("Массив, отсортированный методом вставки: ");
PrintArray(array1);

int[] array2 = GenArray(10, -5, 5);
Console.WriteLine("Массив: ");
PrintArray(array2);
array2 = CountSort(array2);
Console.WriteLine("Массив, отсортированный методом подсчета: ");
PrintArray(array2);