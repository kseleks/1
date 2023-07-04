
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



void GetBinaryView(int num)
{
    // задаем точку остановки, иначе рекурсия будет бесконечной
    if (num==0)
    {
        return;
    }
    GetBinaryView(num/2);
    System.Console.Write(num%2 ); 
}

System.Console.Write("ВВЕДИТЕ ЧИСЛО десятичной системы исчисления: ");
int number = Convert.ToInt32(Console.ReadLine());
GetBinaryView(number);








