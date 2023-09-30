// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Метод заполнения двумерного массива
int[,] GenMatrix(int countRow, int countColumn, int downBorder, int topBorder)
{
    int[,] matrix = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
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

// Метод создания словаря
Dictionary<int, int> CreateFreqDict(int[,] matrix, int downBorder, int topBorder)
{
    
    Dictionary<int, int> freqDict = new Dictionary<int, int>();
    for (int k = downBorder; k < topBorder+1; k++)
    {
        freqDict.Add(k, 0);
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            freqDict[matrix[i, j]]++;
        }
    }
    return freqDict;
}

// Метод печати словаря
void PrintDict(Dictionary<int, int> dict)
{
    foreach( KeyValuePair<int, int> kvp in dict)
    {
        Console.WriteLine("Значение {0} встречается {1} раз", kvp.Key, kvp.Value);
    }
}

int[,] matrix = GenMatrix(3, 3, 1, 10);
PrintMatrix(matrix);
Dictionary<int, int> freqDict = CreateFreqDict(matrix, 1, 10);
PrintDict(freqDict);
