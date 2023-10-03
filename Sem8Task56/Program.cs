//------------------------------------------------------------------------------------------------------------------
// Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

// Считываем даннные для генерации матрицы
int countRow = ReadData("Введите количество строк матрицы:");
int countCol = ReadData("Введите количество столбцов матрицы:");
int downBorder = ReadData("Введите нижнюю границу диапазона:");
int topBorder = ReadData("Введите верхнюю границу диапазона:");
// Генерируем матрицу
int[,] matrix = GenMatrix(countRow, countCol, downBorder, topBorder);
// Выводим матрицу на экран
PrintMatrix(matrix);
Console.WriteLine();
// Сортируем каждую строку матрицы обратно методу пузырька и выводим отсортированную матрицу на экран
(int index, int minRowSum) result = FindMinRow(matrix);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {result.index}, сумма элементов: {result.minRowSum}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Метод чтения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод заполнения матрицы
int[,] GenMatrix(int countRow, int countCol, int downBorder, int topBorder)
{
    int[,] matrix = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            matrix[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return matrix;
}

// Метод печати матрицы
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrix[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод нахождения строки с минимальной суммой элементов, возвращает индекс и сумму
(int index, int minRowSum) FindMinRow(int[,] matrix)
{
    // устанавливаем значения индекса и минимальной суммы строки по-умолчанию
    int index = -1;
    int minRowSum = 0;

    // значение минимальной суммы меняем на сумму эл-тов первой строки, индекс меняем на индекс первой строки
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minRowSum += matrix[0, j];
        index = 0;
    }

    // проходим по остальным строкам
    // если сумма элементов строки меньше минимальной, перезаписываем значение минимальной суммы и индекса
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int currentRowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentRowSum += matrix[i, j];
        }
        if (currentRowSum < minRowSum)
        {
            minRowSum = currentRowSum;
            index = i;
        }
    }
    return (index, minRowSum);
}