// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(-9, 10);
}
return arr; 
// возвращаем заполненный массив
}

bool CheckNumber(int[] arr, int number)
{
for (int i = 0; i < arr.Length; i++)
{
if (number == arr[i])
{
return true;
// возвращаем "есть"
}
}
return false;
// возвращаем "нет числа в массиве"
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckNumber(array, number)) 
{
System.Console.WriteLine("Элемент найден");
}
else
{
System.Console.WriteLine("Элемент НЕ найден");
}
