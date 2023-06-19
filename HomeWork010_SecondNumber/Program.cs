// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondNumber (int argument)
// {
//     int arg1 = argument / 100;
//     // промежуточный контейнер, определяем двухзначный остаток от числа, те 456 ---> 56
//     // и потом выводим целочисленный остаток от деления 
//     int argN = argument - arg1 * 100;
//     int arg2 = argN / 10;

//     return arg2;
// }
// int num = new Random().Next(100,1000);
// System.Console.WriteLine($"Ваше случайное число {num}");
// System.Console.WriteLine($"Вторая цифра числа равна - {SecondNumber(num)} ");



// ДОРАБОТАННЫЙ СПОСОБ

int SecondNumber (int argument)

{
int arg1 = argument / 100;
int arg3 = argument % 10;
int argN = argument - arg1 * 100 - arg3;
int arg2 = argN /10;

return arg2;
}

int num = new Random().Next(100,1000);
System.Console.WriteLine($"Ваше случайное число {num}");
System.Console.WriteLine($"Вторая цифра числа равна - {SecondNumber(num)} ");





