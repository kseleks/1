// задайте массив из Н элементов,заполненных случайных образом из чиселв промежутке [-9;9]
// Найдите сумму ПОЛОЖИТЕЛЬНЫХ и ОТРИЦАТЕЛЬНЫХ ЭЛЕМЕНТОВ МАССИВА

// [3, 9, -8,1,0,-7,2,-1,8,-3,-1,6]
// "+" ------ 29
// "-" ------ -20

int [] FillArrayWithRandomNumber(int size)
{
    int []arr=new int [size];
    Random rnd=new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=rnd.Next(-9,10);
    }
    return arr;
}
System.Console.Write("ВВЕДИТЕ количество элементов массива: ");
int length= Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(String.Join(";", array));

int SumPositive=0;
int SumNegative=0;

for (int i=0; i<array.Length; i++)
{
    if (array[i]>0)
    {
        SumPositive+=array[i];
    }
    else
    {
        SumNegative+=array[i]; 
        // SumNegative= SumNegative + array[i]; 
    }
}
System.Console.WriteLine($"Сумма положительных = {SumPositive}, а сумма отрицательных = {SumNegative}");


