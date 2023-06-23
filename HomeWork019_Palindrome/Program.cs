// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

// System.Console.WriteLine ($"ВВЕДИТЕ ПЯТИЗНАЧНОЕ ЧИСЛО-   ");
// int number = Convert.ToInt32(Console.ReadLine());
// int len = 99998;

// for (int i=0; i<99998/2; i++)
// {
//     if (number[i] != number[len-i-1])
//     {
//         return false;
//         System.Console.WriteLine($"Число{number} не является ПАЛИНДРОМОМ ");
//     }
//     else
//     {
//         return true;
//         System.Console.WriteLine($"ПОЗДРАВЛЯЕМ! Число{number} ЯВЛЯЕТСЯ ПАЛИНДРОМОМ ");
//     }
// }


var chislo = "12346";
if (chislo.Reverse().SequenceEqual(chislo))
    {
        System.Console.WriteLine($"Число{chislo} является ПАЛИНДРОМОМ ");
    }
    else
    {
        System.Console.WriteLine($"ПОЗДРАВЛЯЕМ! Число{chislo} НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ ");
    }







