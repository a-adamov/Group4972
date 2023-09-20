// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
    Console.WriteLine();
}

//
(int, int) NegativePositiveSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posSum += arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
(int pos, int neg) sum = NegativePositiveSum(array);
Console.WriteLine("Сумма положительных чисел: " + sum.pos + ", сумма отрицательных чисел: " + sum.neg);