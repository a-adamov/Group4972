//------------------------------------------------------------------------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
ReversSortInRows(matrix);
PrintMatrix(matrix);

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

// Метод сортировки элементов матрицы построчно (обратно методу пузырька)
void ReversSortInRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1); j > 0; j--)
        {
            for (int k = matrix.GetLength(1)-j; k > 0; k--)
            {
                if (matrix[i, k] > matrix[i, k - 1])
                {
                    int temp = matrix[i, k-1];
                    matrix[i, k - 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}