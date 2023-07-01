// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
if (i%2==1)
    {
        SumOfNumbers=SumOfNumbers+array[i];
    }
}
System.Console.WriteLine(SumOfNumbers);
