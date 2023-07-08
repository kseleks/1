// Задача 46.
// Задайте ДВУМЕРНЫЙ МАССИВ размером m*n
// заполненный случайными числами

// м=3
// н=4

//  1  4   8  19
//  5 -2  33  -2
// 77  3   8   1


void FillMatrixWithRandom(int [,] matrix)
// заполнить матрицу случайными числами
{
    Random rnd=new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j]=rnd.Next(0,10);
        }
    }
}

void PrintMatrix(int[,] matrix)
// вывести на экран матрицу
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            System.Console.WriteLine ($"{matrix[i,j]}");
        }
        System.Console.WriteLine ();
    // перенос на новую строку курсор
    }
}    


System.Console.WriteLine ("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

// создаем двухмерный массив
int[,] matrix =new int [row,column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);






