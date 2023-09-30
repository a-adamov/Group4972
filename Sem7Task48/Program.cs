// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ= m+n. 
// Выведите полученный массив на экран. m = 3, n = 4. 0 1 2 3 1 2 3 4 2 3 4 5

// Тело программы

int countRow = ReadData("Введите количество строк матрицы:");
int countCol = ReadData("Введите количество столбцов матрицы:");
int[,] matrix = GenSumMatrix(countRow, countCol);
PrintMatrix(matrix);


// Методы

// Метод чтения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод заполнения двумерного массива
int[,] GenSumMatrix(int countRow, int countCol)
{
    int[,] matrix = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            matrix[i, j] = i + j;
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