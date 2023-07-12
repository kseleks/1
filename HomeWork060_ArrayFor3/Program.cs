// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWithRandom(int[,,] matrix)
{
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int z = 0; z < matrix.GetLength(2); z++)
{
    matrix[i, j, z] = rnd.Next(10,100);
}
}
}
}

void PrintMatrix(int[,,] matrix)
{

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
for (int z = 0; z < matrix.GetLength(2); z++)
{
    
System.Console.Write($"{matrix[i, j, z]} ({i} {j} {z})");
// выводим сразу индексы элемента 3д массива
}
System.Console.WriteLine();
}
}
}

// попыталась сделать через bool, но не вышло
// bool CheckMatrix (int[,,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         for (int k =0; k < matrix.GetLength(2); k++)
//             {
//                 if (matrix[i,j,k]==matrix[i+1,j,k]);
//                 else if (matrix[i,j,k]==matrix[i,j+1,k]);
//                 else if(matrix[i,j,k]=matrix[i,j,k+1])
//                 {
//                     return true;
//                 }
//                 return false;
//             }         
//         }
//     }

// }



System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во страниц: ");
int list = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[row, column, list];

FillMatrixWithRandom(matrix);

System.Console.WriteLine();
System.Console.WriteLine();


for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
     {
        for (int z = 0; z <matrix.GetLength(2); z++)
        {
        if (matrix[i,j,z] == matrix[i+1,j,z]);
        else if (matrix[i,j,z]==matrix[i,j+1,z]);
        else if (matrix[i,j,z]==matrix[i,j,z+1]);
        {
           FillMatrixWithRandom(matrix);
           PrintMatrix(matrix);
        }
        PrintMatrix(matrix);

     }
}   
}  


// if (CheckMatrix(matrix))
// {
// PrintMatrix(matrix);
// }
// else
// {
// FillMatrixWithRandom(newmatrix);
// PrintMatrix(newmatrix);
// }



