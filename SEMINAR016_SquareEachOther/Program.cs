// программа которая принимает на вход два числа
// проверяет: является ли одно число квадратом другого числа

// 5,25 --да
// -4,16 --да
// 25,5 --да
// 8,9 --нет




bool  SquareEachOther (int numberA, int numberB)
{
    if (numberA % numberB == 0 || numberB % numberA == 0)
    { 
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine($"Введите число ");
int numb1 = Convert.ToInt32 (Console.ReadLine());

System.Console.WriteLine($"Введите число ");
int numb2 = Convert.ToInt32 (Console.ReadLine());


if (SquareEachOther(numb1,numb2))
{
    System.Console.WriteLine ("да");
}
else
{
    System.Console.WriteLine ("нет");
}

