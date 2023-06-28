// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Exponentiation (double num1, double num2)
{
   double exponent =0;
    if (num2==0)
    {
        exponent=1;
        return exponent;
    }
    else
    {
       System.Console.WriteLine ($"{Math.Pow(num1,num2)}");
        
    }
    return exponent= Math.Pow(num1,num2) ;

}
Console.WriteLine ("Введите 1 число:  ");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2 число:  ");
int number2= Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Результат возведения в степень = {Exponentiation (number1, number2)}");