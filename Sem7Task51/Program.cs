// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 
// Сумма элементов главной диагонали: 1+9+2 = 12

// Тело программы

int countRow = ReadData("Введите количество строк матрицы:");
int countCol = ReadData("Введите количество столбцов матрицы:");
int downBorder = ReadData("Введите нижнюю границу диапазона:");
int topBorder = ReadData("Введите верхнюю границу диапазона:");
int[,] matrix = GenMatrix(countRow, countCol, downBorder, topBorder);
PrintMatrix(matrix);
Console.WriteLine("Сумма чисел по главной диагонали: " + SumMainDiag(matrix));

// Методы

// Метод чтения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод заполнения двумерного массива
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

// Метод печати двумерного массива
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

// Метод изменения массива
int SumMainDiag(int[,] matrix)
{
    int countRow = matrix.GetLength(0);
    int countCol = matrix.GetLength(1);
    int sum = 0;
    for (int i = 0; i < countRow && i < countCol; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}