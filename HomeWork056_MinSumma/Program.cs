// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка



void FillMatrixWithRandom(int[,] matrix)
// заполняем массив случайными числами от 0 до 9
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 10);
}
}
}

void PrintMatrix(int[,] matrix)
// печатаем массив на экран
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} \t");
}
System.Console.WriteLine();
}
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();


int SummaElements =0;
int RowMax=0;
int SummaMaxRow=0;
for (int i = 0; i <matrix.GetLength(0); i++)
{
    SummaElements=0;
    for (int j = 0; j <matrix.GetLength(1); j++)
    {
        SummaElements=SummaElements+matrix[i,j];
    if (SummaElements > SummaMaxRow)
        {
            SummaMaxRow=SummaElements;
            RowMax=i;
        }
        
    }
}
System.Console.WriteLine ($"Сумма элементов максимальной строки равна {SummaMaxRow} Индекс строки равен {RowMax}");