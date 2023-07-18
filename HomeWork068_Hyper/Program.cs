﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    // по определению функции 1 условие
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    // по определению функции 2 условие
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    // по определению функции 3 условие
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}
