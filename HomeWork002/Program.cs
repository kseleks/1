﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write ("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("ВВЕДИТЕ второе ЧИСЛО: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 >number2)
{
    Console.WriteLine ($"Число 1- {number1} больше числа 2- {number2}");
}
else
{
    Console.WriteLine ($"Число 2- {number2} больше числа 1- {number1}");
}
