// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string num1 = Console.ReadLine() ?? "0";

Console.WriteLine("Введите второе число");
string num2 = Console.ReadLine() ?? "0";

int a = int.Parse(num1);
int b = int.Parse(num2);

if (a > b)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" большее");    
}
else if (b > a)
{
    Console.Write("Число ");
    Console.Write(b);
    Console.Write(" большее");    
}
else
{
    Console.WriteLine("Числа равны");
}

//Альтернативный варинат через case

// Console.WriteLine("Введите первое число");
// string num1 = Console.ReadLine() ?? "0";

// Console.WriteLine("Введите второе число");
// string num2 = Console.ReadLine() ?? "0";

// int a = int.Parse(num1);
// int b = int.Parse(num2);

// switch (a - b)
// {
//     case > 0: Console.WriteLine("Число " + a + " больше, чем " + b);
//     break;

//     case < 0: Console.WriteLine("Число " + a + " меньше, чем " + b);
//     break;

//     default: Console.WriteLine("Вы ввели одинаковые числа");
//     break;
// }