// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


int temp = 0;
int[,]newmatrix=matrix;
for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
     {
        for (int z=0; z <matrix.GetLength(1)-1; z++)
        // дополнительный коээфициент по индексу строки
        // применяем метод "пузырьковой" сортировки
        if (matrix[i,z]>matrix[i,z+1])
        {
            temp= matrix[i,z];
            matrix[i,z]= matrix[i,z+1];
            matrix[i,z+1]=temp;
        }
        
     }
}     
PrintMatrix(newmatrix);
