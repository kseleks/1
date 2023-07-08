// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrixWithRandom(int[,] matrix)
// заполнение матрицы случайными числами
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
// вывод на экран матрицы
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

int PositioninMatrix(int[,] matrix, int num)
// // переборка элементов матрицы для сравнения с числом
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j]== num)
        {
        Console.WriteLine($"yes i={i} ; j={j} ");
        }
        else 
        {
        Console.WriteLine("no");
        }
        
    }
}
return num;
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО: ");
int number = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];

FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

PositioninMatrix(matrix, number);







