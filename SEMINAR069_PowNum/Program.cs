// Напишите программу которая на вход принимает да числа А и В и возводит число А в целую степень В
// с помощью рекурсии

// А=3;
// В=5

// результат равен 243 (3 в степени 5)

int PowNum(int x, int y)
{
    if (y==0)
    {
        return 1;
    }
    return x*PowNum(x,y-1);
}

System.Console.Write("ВВЕДИТЕ число 1: ");
int number1= Convert.ToInt32(Console.ReadLine());
System.Console.Write("ВВЕДИТЕ число 2: ");
int number2= Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(PowNum (number1, number2));
