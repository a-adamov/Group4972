// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю

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

// Метод подсчета суммы нечетных элементов
int SumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) // суммируем только нечетные элементы
    {
        sum += arr[i];
    }
    return sum;
}

// Метод поиска и вывода пар
void FindPair(int[] arr)
{
    Console.WriteLine("В массиве обнаружены пары (значение[индекс]):");
    List<int> allPairIndexes = new List<int>(); // создаем пустой лист для записи индексов найденных пар
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            if (!allPairIndexes.Contains(i) && !allPairIndexes.Contains(j) && arr[i] == arr[j]) // проверяем что найденные пары не содержатся в списке парных элементов
            {
            Console.WriteLine($"{arr[i]}[{i}] - {arr[j]}[{j}]"); // выводим значения и индексы парных элементов
            allPairIndexes.Add(i); // вносим индексы в лист парных элементов
            allPairIndexes.Add(j);
            break;
            }
        }
    }
}


int[] array = GenArray(10, 0, 9);
Console.WriteLine("Массив: ");
PrintArray(array);
int sum = SumOdd(array);
Console.WriteLine("Сумма нечетных элементов: " + sum);
FindPair(array);
