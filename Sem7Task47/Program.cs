
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

 public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i=0; i<m; i++)
    {
      for (int j=0; j<n; j++)
      {
        matrix[i, j] = rnd.Next(minLimitRandom, maxLimitRandom)+ Math.Round(rnd.NextDouble(), 2);
      }
    }
    return matrix;
    
  }

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
for (int i=0; i<m; i++)
    {
      for (int j=0; j<n; j++)
      {
        Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
    }
   
  }