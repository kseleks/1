// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int Phrase(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int ThirdArgument(int number)
// метод в котором number понижаем на десяток 
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

bool Proverka(int number)
// проверка на актуальность числа
{
    if (number < 100)
    {
        Console.WriteLine("Theri is not 3 number");
        return false;
    }
    return true;
}

int number = Phrase("VVOD-  ");
if (Proverka(number))
// если число соответствует заданным требованиям мы переходим к методу
{
    Console.WriteLine(ThirdArgument(number));

}