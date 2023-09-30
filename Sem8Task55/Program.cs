// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Метод заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}
// Метод печати двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод проверки равенства строк и стоблцов массива
bool TestQuadMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

// Метод поворота массива
void Rotate2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;

        }
    }
}

int[,] matrix = Fill2DArray(5, 5, 1, 10);
Print2DArray(matrix);
Console.WriteLine();

if(TestQuadMatrix(matrix))
{
    Rotate2DArray(matrix);
    Print2DArray(matrix);
}
else {Console.WriteLine("Матрицу невозможно траспонировать");}

