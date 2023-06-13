// Написать программу, которая принимает на ВХОД трехзначное число 
// и на выходе показывает последнюю цифру этого числа

Console.WriteLine ("ВВЕДИТЕ трезначное число- ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number > 99 || number < 1000)
{
    Console.WriteLine (number = number % 110);
}
else
{
    Console.WriteLine ($"Число{number} не подходит по условию задачи");
}

