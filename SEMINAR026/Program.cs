// Задача 26: Напишите программу, 
// которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



int DigitCapacity (int num)
{
    int digitcapacity=0;
    int buff=0;
    if (num==0)
    {
        digitcapacity=1;
        return digitcapacity;
    }
    else
    {
        for(int i=1; buff!=num; i=i*10)
        {
            buff=buff+i*((num/i)%10);
            digitcapacity++;
        }
        return digitcapacity;

    }
}
Console.WriteLine ("Введите число:  ");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Количество цифр в числе {number} = {DigitCapacity(number)}");


