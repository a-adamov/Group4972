// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

// Вводим данные
double GetNum(string msg)
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}
string GetStr(string msg)
{
    Console.WriteLine(msg);
    string str = Console.ReadLine() ?? " ";
    return str;
}

// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Складываем
void CalcSum(double A, double B)
{
    double res = A + B;
    PrintResult("Результат сложения: " + res);
}

// Вычитаем
void CalcDiff(double A, double B)
{
    double res = A - B;
    PrintResult("Результат вычитания: " + res);
}

// Умножаем
void CalcProd(double A, double B)
{
    double res = A * B;
    PrintResult("Результат умножения: " + res);
}

// Делим
void CalcQuot(double A, double B)
{
    string msg = (B == 0) ? "Деление на 0 невозможно" : $"Результат деления: {A / B}";
    PrintResult(msg);
}

// Возводим в степень
void CalcPow(double A, double B)
{
    double res = Math.Pow(A, B);
    PrintResult("Результат возведения в степень: " + res);
}

// Принимаем данные и производим вычисления
void DoCalc()
{
    double A = GetNum("Введите первое число: ");
    string oper = GetStr("Введите одну из математических операций: +, -, /, *, ** (возведение в степень)");
    double B = GetNum("Введите второе число: ");
    switch (oper)
    {
        case "+":
            CalcSum(A, B);
            break;
        case "-":
            CalcDiff(A, B);
            break;
        case "/":
            CalcQuot(A, B);
            break;
        case "*":
            CalcProd(A, B);
            break;
        case "**":
            CalcPow(A, B);
            break;
        default:
            Console.WriteLine("Ошибка ввода математической операции");
            break;
    }
}

// Запускаем калькулятор
DoCalc();