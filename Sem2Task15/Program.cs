// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

Console.WriteLine("Введите порядковый номер дня недели");
int numOfDay = int.Parse(Console.ReadLine() ?? "0");

void var1()
{
    Console.WriteLine("Простой способ");
    Console.WriteLine((numOfDay > 0 && numOfDay < 8) ? ((numOfDay > 5) ? "выходной" : "будний") : "Это не порядковый номер дня недели");
}

void var2()
{
    Console.WriteLine("Способ со словарем");
    
    // Создаем словарь
    Dictionary<string, string> dayOfWeek = new Dictionary<string, string>();
    
    // Заполняем словарь
    dayOfWeek["1"] = "будний";
    dayOfWeek["2"] = "будний";
    dayOfWeek["3"] = "будний";
    dayOfWeek["4"] = "будний";
    dayOfWeek["5"] = "будний";
    dayOfWeek["6"] = "выходной";
    dayOfWeek["7"] = "выходной";

    Console.WriteLine((numOfDay > 0 && numOfDay < 8) ? dayOfWeek[numOfDay.ToString()] : "Это не порядковый номер дня недели");
}

var1();
var2();
