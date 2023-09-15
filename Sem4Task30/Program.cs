// Задача 30:Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выводим результат
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

// Генерируем массив
int[] GenArray(int len)
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

int len = ReadData("Введите длину массива: ");
int[] array = GenArray(len);
PrintArray(array);
