﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int n = 8;
int[] num = new int [n];
for (int i = 0; i < n; i++)
{
    num[i] = new Random().Next(0,100);
    Console.Write($"{num[i]} ");
}