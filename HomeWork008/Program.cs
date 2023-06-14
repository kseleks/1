//  Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write ("Введите число- ");
// int number = Convert.ToInt32 (Console.ReadLine());
// int count = 1;

// while (count <= number && number >0)
//     { 
//    if  (0 = count % 2)
//     {
//      Console.Write ($"{count}");
//     }
//     else count++;
// }
// { 
//     Console.Write ($"Не подходит по условию задачи");
//     return;
// }

Console.Write ("Введите число- ");
int number = Convert.ToInt32 (Console.ReadLine());
int count = 1;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write ($"{count} ;");
    }
count++;
}

   
