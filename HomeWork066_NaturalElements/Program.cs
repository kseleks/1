// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNaturalElements(int M,int N)
// сумма натуральных чисел от M - N
{
    int result=M;
    if (M == N)
        {   
            System.Console.WriteLine($"{M}");
            return 0;
        }
    else
    result= M+SumNaturalElements(M,N);
    return result;

}
Console.Write("Введите ПЕРВОЕ число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ВТОРОЕ число:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

SumNaturalElements(number1, number2);
