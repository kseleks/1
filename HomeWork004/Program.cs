//  Напишите программу, которая принимает на вход три числа 
// и выдаёт МАКСИМАЛЬНОЕ из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("ВВЕДИТЕ первое ЧИСЛО: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("ВВЕДИТЕ второе ЧИСЛО: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("ВВЕДИТЕ третье ЧИСЛО: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1>number2 && number1>number3)
{
    Console.Write ($"Максимальное число {number1}  !");
}
else if (number2>number1 && number2>number3)
{
    Console.Write ($"Максимальное число {number2}");
}
else if (number3>number1 && number3>number2)
{
   Console.Write ($"Максимальное число {number3}");
}
else
{
    Console.Write ($"Есть повторяющиеся числа");
    }