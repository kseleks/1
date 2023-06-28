// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SUM (int num)
{
    int summa=0;
    // СЧЕТЧИК ЦИКЛА

    if (num==0)
    {
       summa=0;
        return summa;
    }
    else
    {
        while (num>0)
        {
            summa=summa + num%10; 
            // if number=82, 0+2
            num=num/10;
            // 8
        }

        return summa;

    }
}

Console.WriteLine ("Введите число:  ");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"СУММА ЦИФР числа = {SUM(number)}");


