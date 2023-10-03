

//------------------------------------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------

// Считываем даннные для генерации массива
int countRow = ReadData("Введите количество строк матрицы:");
int countCol = ReadData("Введите количество столбцов матрицы:");
int countDepth = ReadData("Введите глубину матрицы:");

int downBorder = ReadData("Введите нижнюю границу диапазона:");
int topBorder = ReadData("Введите верхнюю границу диапазона:");

// Проверяем возможность заполнения массива уникальными значениями
Console.WriteLine(!CheckFillUnique(countRow, countCol, countDepth, downBorder, topBorder) ? 
"Невозможно заполнить массив уникальными значениями." : "Трехмерный массив с уникальными значениями:");

// Генерируем массив
int[,,] cube = GenCube(countRow, countCol, countDepth, downBorder, topBorder);

// Выводим массив на экран
Console.WriteLine();
PrintCube(cube);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Метод чтения данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод проверки возможности заполнения массива уникальными значениями
bool CheckFillUnique(int countRow, int countCol, int countDepth, int downBorder, int topBorder)
{
    return (countRow * countCol * countDepth <= topBorder - downBorder);
}


// Метод заполнения массива
int[,,] GenCube(int countRow, int countCol, int countDepth, int downBorder, int topBorder)
{
    int[,,] cube = new int[countRow, countCol, countDepth]; // задаем размерность массива
    List<int> usedNumbers = new List<int>(); // создаем лист использованных значений в массиве
    for (int i = 0; i < countRow; i++) // проходим по строкам, столбцам и глубине массива для создания каждого элемента
    {
        for (int j = 0; j < countCol; j++)
        {
            for (int k = 0; k < countDepth; k++)
            {
                while (usedNumbers.Contains(cube[i, j, k])) // проверям не использовалось ли это значение ранее
                {
                    cube[i, j, k] = new Random().Next(downBorder, topBorder + 1); // геренируем случайное значение из диапазона
                }
                usedNumbers.Add(cube[i, j, k]); // записываем значение в лист использованных
            }
        }
    }
    return cube;
}

// Метод печати матрицы
void PrintCube(int[,,] cube)
{
    for (int k = 0; k < cube.GetLength(2); k++) // проходим по массиву, сначала показываем строки и столбцы, затем третье измерение
    {
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{cube[i, j, k]}({i},{j},{k})\t"); // выводим значение каждого элемента и его индекс
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}