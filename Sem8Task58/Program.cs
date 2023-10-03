//------------------------------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

// Считываем даннные для генерации матриц
int countRow1 = ReadData("Введите количество строк первой матрицы:");
int countCol1 = ReadData("Введите количество столбцов первой матрицы:");

int countRow2 = countCol1;
int countCol2 = ReadData("Введите количество столбцов второй матрицы:");

int downBorder = ReadData("Введите нижнюю границу диапазона:");
int topBorder = ReadData("Введите верхнюю границу диапазона:");

// Генерируем матрицы
int[,] matrix1 = GenMatrix(countRow1, countCol1, downBorder, topBorder);
int[,] matrix2 = GenMatrix(countRow2, countCol2, downBorder, topBorder);

// Выводим матрицы на экран
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
Console.WriteLine();

// Умножаем матрицы и выводим результат на экран
int[,] result = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);
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

// Метод умножения матриц
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    // определяем размерности матриц
    int countRow1 = matrix1.GetLength(0);
    int countCol1 = matrix1.GetLength(1);
    int countRow2 = countCol1;
    int countCol2 = matrix2.GetLength(1);

    int[,] result = new int[countRow1, countCol2]; // задаем размер результирующей матрицы

    for (int k = 0; k < countCol2; k++) // перебираем столбцы второй матрицы
    {
        for (int i = 0; i < countRow1; i++) // перебираем строки первой матрицы
        {
            int scalarProd = 0;
            for (int j = 0; j < countCol1; j++) // перебираем столбцы первой матрицы и строки второй матрицы
            {
                scalarProd += matrix1[i, j] * matrix2[j, k]; // считаем скалярное произведение строк первой матрицы и столбцов второй
            }
            result[i, k] = scalarProd; // записываем скалярные произведения в результирующую матрицу
        }
    }
    return result;
}