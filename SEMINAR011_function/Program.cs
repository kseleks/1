// Напишите программу которая выводит случайное трехзначное число
// и удаляет вторую цифру  

// 456 ---> 46
// 782 ---> 72
// 918 ---> 98

int Funktion(int number)
{
int arg1 = number / 100 ;
int arg2 = number % 10;
int result = arg1 * 10  + arg2;

return result;
}

int num = new Random().Next(100, 1000);
System.Console.WriteLine ($"Ваше случайное число Х {num}");
System.Console.WriteLine ($"Программа выводит случайное число {num} БЕЗ ВТОРОЙ ЦИФТРЫ:  {Funktion(num)}");
