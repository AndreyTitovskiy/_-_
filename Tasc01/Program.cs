﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число а: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == numberA * numberA)
{
    Console.WriteLine($"да, число {numberA} является квадратом числа {numberB}");
}
else
{
    Console.WriteLine($"нет, число {numberA} не является квадратом числа {numberB}");
}
