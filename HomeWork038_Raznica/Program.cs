// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] FillArrayWithRandomNumber(int size)
{
    double []mass =new double [size];
    Random rnd = new Random();
    for (int i=0; i<mass.Length; i++)
    {
        mass[i] = rnd.NextDouble();
    }
    return mass;
}

System.Console.Write("ВВЕДИТЕ количество элементов массива: ");
int length= Convert.ToInt32(Console.ReadLine());
double [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(String.Join(";", array));

double MinElement=array[0];
double MaxElement=array[0];
double razn=0;
for (int i = 0; i < array.Length; i++)
if (array[i] > MaxElement)
    {
    MaxElement=array[i];
    }
else if (array[i]< MinElement)
    {
    MinElement=array[i];
    } 
razn= MaxElement-MinElement;  

System.Console.WriteLine($"разница равна {razn}");
// переменная подсчитывает разницу между максимальным элементом массива 
// и минимальным элементом массива

