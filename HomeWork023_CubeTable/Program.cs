// Задача 23
// Напишите программу, которая принимает на вход число N и выводит
// ТАБЛИЦУ КУБОВ ЧИСЕЛ ОТ 1 до N

// 3--- 1,8,27
// 5---1,8,27,64,125

System.Console.Write ("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО ОТ 1 до N-  ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<= number; i++)
// инкремент равен 1
// i++ счетчик
{
    System.Console.WriteLine($"{Math.Pow(i,3)},");
}