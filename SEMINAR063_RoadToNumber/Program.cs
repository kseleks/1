// Задача 63.
// Задайте значение N 
// Напишите программу которая выведет все натуральные числа в промежутке от 1 до N 

// N = 5
// выводим 1,2,3,4,5
// N = 6
// выводим 1,2,3,4,5,6

// void RoadToNumber(int number)
// {
// if (number==0)
//     {
//     return;
//     }
// RoadToNumber(number-1);
// System.Console.Write($"{number }");
// }

// System.Console.Write("ВВЕДИТЕ число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// RoadToNumber(number);

void RoadToNumber(int n)
{
   {
    if (n > 0)
    {
        RoadToNumber (n - 1);
    }
} 
}

 System.Console.Write("ВВЕДИТЕ число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number);