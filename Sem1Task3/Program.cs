// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели");

int day = int.Parse(Console.ReadLine() ?? "0");
string[] dayOfWeek = new string[7];

dayOfWeek[0] = "ПН";
dayOfWeek[1] = "ВТ";
dayOfWeek[2] = "СР";
dayOfWeek[3] = "ЧТ";
dayOfWeek[4] = "ПТ";
dayOfWeek[5] = "СБ";
dayOfWeek[6] = "ВС";

Console.WriteLine(dayOfWeek[day - 1]);

//Альтернативный вариант через switch

// Console.WriteLine("Введите номер дня недели");

// int day = int.Parse(Console.ReadLine() ?? "0");

// switch (day)
// {
//     case 1:
//         Console.WriteLine("ПН");
//         break;

//     case 2:
//         Console.WriteLine("ВТ");
//         break;

//     case 3:
//         Console.WriteLine("СР");
//         break;

//     case 4:
//         Console.WriteLine("ЧТ");
//         break;

//     case 5:
//         Console.WriteLine("ПТ");
//         break;

//     case 6:
//         Console.WriteLine("СБ");
//         break;

//     case 7:
//         Console.WriteLine("ВС");
//         break;

//     default:
//         Console.WriteLine("Это не номер дня недели");
//         break;
// }