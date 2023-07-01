﻿
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 10);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int newLength = array.Length / 2 + array.Length % 2;
// определяем длину массива нового
int[] newArray = new int[newLength];

for (int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}
// заполнение массива для i элемента


if (array.Length % 2 == 1)
// если длина массива в остатке от деления на 1, те есть "серединка" В КОНЦЕ
{
newArray[newArray.Length - 1] = array[array.Length / 2];
}
// ЗАПОЛНЯЕМ ее серединой старого массива


System.Console.WriteLine(string.Join("; ", newArray));

