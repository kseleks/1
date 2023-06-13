// Написать программу, которая на входетпринимает два числа и проверяет
// ЯВЛЯЕТСЯ ли ПЕРВОЕ ЧИСЛО квадратом ВТОРОГО

Console.Write("Введите первое чило- ");
int number1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите второе чило- ");
int number2 = Convert.ToInt32 (Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Действительно,ПЕРВОЕ число {number1} является квадратом ВТОРОГО числа {number2}");
}
else
{
    Console.WriteLine($"ПЕРВОЕ  число {number1} не является квадратом ВТОРОГО числа {number2} ");
}
