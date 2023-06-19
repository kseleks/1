// напишите программу, которая будет принимать на вход два числа и выводить,
// ЯВЛЯЕТСЯ ЛИ ВТОРОЕ ЧИСЛО КРАТНЫМ ПЕРВОМУ.

// Если число 2 не кратно числу 1, то программа выводит ОСТАТОК от деления 

// 34, 5 ---> не кратно ОСТАТОК от деления =4
// 16, 4 ---> КРАТНО

int MultiplicityCheck(int arg1, int arg2)
{
    int result = 0;
    if (arg1/arg2 > 0)
        { 
            result = arg1/arg2;
            return result;
        }
    else
    {
         return result;
    }
}

int num1 = new Random().Next(0, 100);
int num2 = new Random().Next(0,100);
System.Console.WriteLine ($"Ваше случайное ПЕРВОЕ ЧИСЛО {num1}");
System.Console.WriteLine ($"Ваше случайное ВТОРОЕ ЧИСЛО {num2}");




// System.Console.WriteLine ($"ПЕРВОЕ ЧИСЛО {num1} кратно ВТОРОМУ ЧИСЛУ {num2}");
System.Console.WriteLine ($"ПЕРВОЕ ЧИСЛО {num1} НЕ КРАТНО ВТОРОМУ ЧИСЛУ {num2}, остаток от деления равен {MultiplicityCheck(num1,num2)}");
