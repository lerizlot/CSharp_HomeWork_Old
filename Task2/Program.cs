// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a1 = 5; b1 = 7 -> max1 = 7
// a2 = 2 b2 = 10 -> max2 = 10
// a3 = -9 b3 = -3 -> max3 = -3

// первый вариант
int a1 = 5;
int b1 = 7;
int max1 = 0;

if (a1 < b1) max1 = b1;
if (a1 > b1) max1 = a1;

Console.Write("max1 = ");
Console.WriteLine(max1);

int a2 = 2;
int b2 = 10;
int max2 = 0;

if (a2 < b2) max2 = b2;
if (a2 > b2) max2 = a2;

Console.Write("max2 = ");
Console.WriteLine(max2);

int a3 = -9;
int b3 = -3;
int max3 = 0;

if (a3 < b3) max3 = b3;
if (a3 > b3) max3 = a3;

Console.Write("max3 = ");
Console.WriteLine(max3);

// альтернативный вариант
Console.WriteLine("Введите число a");
int a0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b0 = Convert.ToInt32(Console.ReadLine());

if (a0 < b0){
Console.WriteLine("Max = ");
Console.WriteLine(b0);
}

