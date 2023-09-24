// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// (со звездочкой) Отсортировать массив методом пузырька

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

// Метод подсчета чисел в массиве
int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) // проверяем на четность
        {
            count++;
        }
    }
    return count;
}

// Метод сортировки пузырьком
int[] BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++) // проходим по массиву количество раз, равное его длине,
    // кроме последнего раза, т.к. к этому моменту все числа отсортированы
    {
        bool isReplace = false; // проверяем, что при очередном проходе были перестановки и массив еще не отсортирован
        for (int j = 0; j < arr.Length - i - 1; j++) // на каждом проходе попарно сравниваем числа и переставляем большее число в конец,
        // при каждом следующем проходе не учитываем уже отсортированные числа
        {
            if (arr[j] > arr[j + 1]) //переставляем числа, если правое меньше левого
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                isReplace = true;
            }
        }
        if (isReplace == false) break; // прерываем сортировку, если перестановок при проходе не было
    }
    return arr;
}

int[] array = GenArray(10, 100, 999);
Console.WriteLine("Массив: ");
PrintArray(array);
int count = CountEven(array);
Console.WriteLine("Количество четрых чисел в массиве: " + count);
BubbleSort(array);
Console.WriteLine("Отсортированный массив: ");
PrintArray(array);