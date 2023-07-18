// Задача 67
// Напишите прграмму которая  будет принимать на вход число и возвращать сумму его цифр.

// 453--->12
// 45---->9
// СЛОЖЕНИЕ ТИПОВОЙ РЕКУРСИЕЙ

int SumDigital(int number)
{
    if (number==0)
    {
        return 0;
    }
    return number % 10 + SumDigital(number/10);
}

System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО: ");
int number = Convert.ToInt32(Console.ReadLine);
System.Console.WriteLine (SumDigital(number));
