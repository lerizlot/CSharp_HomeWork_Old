// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");

string num = Console.ReadLine()!;

if (num!.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
        Console.WriteLine($"Число {num} не является палиндромом");
}
else
    Console.WriteLine($"Введённое число {num} не соответствует условиям задачи");

// Альтернативное решение от преподователя

Console.WriteLine("Введите пятизначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[4];
int i = 0;
while(num1 > 0)
{
    arr[i] = num1 % 10; // тут что-то не так...
    num1 /= 10;
    i--;
}

if (arr[0] == arr[4] && arr[1] == arr[3])
{
    Console.WriteLine($"Число {num1} является палиндромом");

}
else
{
    Console.WriteLine($"Число {num1} не является палиндромом");

}

// Универсальное решение от преподавателя

Console.WriteLine("");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num2;
int result = 0;
while (num2 > 0)
{
    result = result * 10 + num2 % 10;
    num2 /= 10;
}

if (num3 == result)
{
    Console.WriteLine($"Число {num2} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num2} не является палиндромом");
}