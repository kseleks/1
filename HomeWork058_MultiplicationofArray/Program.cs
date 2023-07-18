// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplicationOfTwoArray(int[,] matrix01, int[,] matrix02)
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


System.Console.WriteLine("Введите кол-во строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[row1, column1];
int[,] matrix2 = new int[row2, column2];

FillMatrixWithRandom(matrix1);
PrintMatrix(matrix1);
System.Console.WriteLine();

FillMatrixWithRandom(matrix2);
PrintMatrix(matrix2);
System.Console.WriteLine();

