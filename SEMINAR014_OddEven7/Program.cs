// Программа которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
// 14 -- нет
// 46 -- нет
// 161 -- да

bool  OddEven (int number)

{
    if (number % 7 == 0 && number % 23 == 0)
    { 
        return true;
    }
    else
    {
        return false;
    }
}


System.Console.WriteLine($"Введите число ");
int numb = Convert.ToInt32 (Console.ReadLine());

if (OddEven (numb))
{
    System.Console.WriteLine ($"Число {numb} кратно 7 & 23");
}
else
{
    System.Console.WriteLine ($"Число {numb} НЕ кратно 7 & 23");
}
