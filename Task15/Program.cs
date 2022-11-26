// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяеи, является ли этот день выходным

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите ваше число");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

switch (DayOfWeek)
{
    case 1:
        Console.WriteLine("Monday. It's a working day :(");
        break;
    case 2:
        Console.WriteLine("Tuesday. It's a working day :(");
        break;
    case 3:
        Console.WriteLine("Wednesday. It's a working day :(");
        break;
    case 4:
        Console.WriteLine("Thursday. It's a working day :(");
        break;
    case 5:
        Console.WriteLine("Friday. It's a working day :(");
        break;
    case 6:
        Console.WriteLine("Saturday. It's a weekend !");
        break;
    case 7:
        Console.WriteLine("Sunday. It's a weekend !");
        break;
    default:
        Console.WriteLine("No Day");
        break;
}
