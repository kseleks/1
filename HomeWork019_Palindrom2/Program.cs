// S// Задача 19
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



// int IndexOf (int[] collection, int find);
// int count = collection.Length;
// int index =0;
// int position=0;
// while (index<count);

// {
// if (number[i] != number[len-i-1] && (number[i]) != number [len-i-2] )
//      {
//         System.Console.WriteLine($"ПОЗДРАВЛЯЕМ! Число{number} ЯВЛЯЕТСЯ ПАЛИНДРОМОМ ");
//      }
//     else
//     {
//         System.Console.WriteLine($" Число{number} ne ЯВЛЯЕТСЯ ПАЛИНДРОМОМ ");
//     }
// }


// int Phrase(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// bool Proverka(int number)
// // проверка на актуальность числа  по условию задачи
// {
//     if (number < 100000 && number >1000)
//     {
//         Console.WriteLine("Theri is not 3 number");
//         return false;
//     }
//     return true;
// }

// bool Palindrom(string number);
// // метод в  котором идет проверка числа на палиндромность

// int length = number.Length;
// for (int i=0; i<length/2; i++);
// {
//     if (number[i] = number[length - i - 1])
//     {
//     return true;
//     }
//     else
//     {
//     return false;
//     }
// }

// char number = Phrase("VVOD -  ");

// if (Proverka(number))
// {
// // если число соответствует заданным требованиям мы переходим к методу
//    {
//     Console.WriteLine(Palindrom(number));
//    }
// }
// int num = new Random().Next(9999,100000);
// System.Console.Writeline($"Ваше случайное пятизначное число-  ");
// System.Console.WriteLine($"Программа выводит {Palindrom(num)}");

// ------------------------------------------------------

bool isPalindrome(int n)
{
     int rev = 0;
     int num = n;
 
    if (n == 0) 
    {
        return (num == rev);
    }
 
    rev = rev * 10 + n % 10;
    return isPalindrome(n / 10);
}


int Main (int num)
{
    
    if (isPalindrome(num)) 
    {
        System.Console.WriteLine( "Palindrome");
    }
    else 
    {
         System.Console.WriteLine( "There ia not");
    }
}
System.Console.Write($"Ваше случайное пятизначное число-  ");
int num = Convert.ToInt32(Console.ReadLine);

if (Main(num))
// если число соответствует заданным требованиям мы переходим к методу
{
    Console.WriteLine($" {num} PALINDROM");
}
else
{
    Console.WriteLine($" {num} NOT A PALINDROM");
}

 
