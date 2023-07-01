// Задача 35: Задайте одномерный массив из N случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] FillArrayWithRandomNumber(int size)
// заполнение массива случайными числами
{
    int []arr=new int [size];
    Random rnd=new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=rnd.Next(10,100);
    }
    return arr;
}

System.Console.Write("ВВЕДИТЕ количество элементов массива: ");
int length= Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(String.Join(";", array));
System.Console.Write("ВВЕДИТЕ интервал от: ");
int number1= Convert.ToInt32(Console.ReadLine());
System.Console.Write("ВВЕДИТЕ интервал до: ");
int number2= Convert.ToInt32(Console.ReadLine());


int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] >= number1 && array[i] <= number2)
{
count++;
}
}
System.Console.WriteLine(count);



