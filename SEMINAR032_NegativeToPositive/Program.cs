﻿
// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] FillArrayWithRandomNumber(int size)
{
    int []arr=new int [size];
    Random rnd=new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=rnd.Next(-9,10);
    }
    return arr;
}
System.Console.Write("ВВЕДИТЕ количество элементов массива: ");
int length= Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(String.Join(";", array));

for (int i=0; i<array.Length; i++)
{
   array[i]=  - (array[i]);
}
System.Console.WriteLine(String.Join(",", array));



