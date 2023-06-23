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




var chislo = "12321";
// var чтобы не указывать явный тип переменной
if (chislo.Reverse().SequenceEqual(chislo))
// метод Reverse() обращает порядок элементов в обратном направлении
// SequenceEqual, определяет совпадают и две последовательности
    {
        System.Console.WriteLine($"ПОЗДРАВЛЯЕМ! Число{chislo} является ПАЛИНДРОМОМ ");
    }
    else
    {
        System.Console.WriteLine($"Число{chislo} НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ ");
    }
// выводы






