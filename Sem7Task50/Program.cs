// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<m; j++)
      {
        Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
    }      

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int[,] matrix = new int[n,m];
    int elem = 1;
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<m; j++)
      {
        matrix[i, j] = elem;
        elem += k;
      }
    }
    return matrix;

    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      int[] results = new int[2];
      int m = matrix.GetLength(0);
      int n = matrix.GetLength(1);
      if (rowPosition <= n && columnPosition <= m)
      {
        results[0] = matrix[rowPosition-1, columnPosition-1];
        results[1] = 0;
      }
      else {results = new int[1] {0};}
      return results;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
      if (results.Length == 2)
      {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
      }
      else
      {
        Console.WriteLine("There is no such index");
      }
    }