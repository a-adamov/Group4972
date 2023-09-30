// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.

using System;

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
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
    Console.WriteLine("The averages in columns are: ");
    for (int i=0; i<list.Length; i++)
    {
      Console.Write($"{list[i]:f2}\t");
    }

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
    
    double n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    double[] listAvr = new double[m];
    for (int j=0; j<m; j++)
    {
      int columnSum = 0;
      for (int i=0; i<n; i++)
      {
        columnSum += matrix[i, j];
      }
      listAvr[j] = columnSum/n;
    }   
    return listAvr;
    }