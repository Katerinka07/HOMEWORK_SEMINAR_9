﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
int SumNumbers(int start, int end)
{
    if (start > end)
        return 0;
    return (start + SumNumbers(start + 1, end));
}
int M = InputNum("Введите целое число М: ");
int N = InputNum("Введите целое число N: ");
Console.WriteLine($"Cумма элементов в промежутке от {M} до {N} равна {SumNumbers(M, N)}");
