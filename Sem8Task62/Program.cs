//------------------------------------------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

// Считываем даннные для генерации матрицы
int size = ReadData("Введите размерность квадратной матрицы:");

// Генерируем матрицу
int[,] matrix = GenSpiralMatrix(size);

// Выводим матрицу на экран
Console.WriteLine();
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

// Метод заполнения матрицы по спирали
int[,] GenSpiralMatrix(int size)
{
    int[,] spiralMatrix = new int[size, size]; // задаем размерность матрицы
    int currentfirstRow = 0; // текущая первая строка
    int currentfirstCol = 0; // текущая первая колонка
    int currentlastRow = size - 1; // текущая последняя строка
    int currentlastCol = size - 1; // текущая последняя колонка
    int currentElement = 0; // значение текущего элемента
    
    while (currentlastCol - currentfirstCol > 1 && currentlastRow - currentfirstRow > 1) // проверяем, что размер матрицы больше 2х2
    {
        //заполнение верхней грани
        for (int j = currentfirstCol; j <= currentlastCol; j++)
        {
            spiralMatrix[currentfirstRow, j] = currentElement;
            currentElement++;
        }
        //заполнение правой грани
        for (int i = currentfirstRow + 1; i <= currentlastRow; i++)
        {
            spiralMatrix[i, currentlastCol] = currentElement;
            currentElement++;
        }
        //заполнение нижней грани
        for (int j = currentlastCol - 1; j >= currentfirstCol; j--)
        {
            spiralMatrix[currentlastRow, j] = currentElement;
            currentElement++;
        }
        //заполнение левой грани
        for (int i = currentlastRow - 1; i > currentfirstRow; i--)
        {
            spiralMatrix[i, currentfirstCol] = currentElement;
            currentElement++;
        }
        // задаем новые индексы строк и колонок для заполнения
        currentfirstRow++;
        currentlastRow--;
        currentfirstCol++;
        currentlastCol--;
        // заполняем центральный элемент для нечетных матриц
        if (currentfirstCol == currentlastCol && currentfirstRow == currentlastRow)
        {
            spiralMatrix[currentfirstRow, currentfirstCol] = currentElement;
        }
        // заполняем матрицу 2х2
        if (currentfirstCol + 1 == currentlastCol && currentfirstRow + 1 == currentlastRow)
        {
            spiralMatrix[currentfirstRow, currentfirstCol] = currentElement;
            spiralMatrix[currentfirstRow, currentlastCol] = currentElement + 1;
            spiralMatrix[currentlastRow, currentlastCol] = currentElement + 2;
            spiralMatrix[currentlastRow, currentfirstCol] = currentElement + 3;
        }
    }
    return spiralMatrix;
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