// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;


double Distance2D (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
double distance=Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2));
return Math.Round(distance, 2);
//  округляем до второго знака значение переменной
}

System.Console.Write("ВВЕДИТЕ координаты Х точки А: ");
double Ax=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Y точки А: ");
double Ay=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Z точки А: ");
double Az=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты X точки B: ");
double Bx=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Y точки B: ");
double By=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Z точки B: ");
double Bz=Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"Расстояние  между точками А и В= {Distance2D (Ax,Ay,Az,Bx,By,Bz)} ");
// выводим расстояние между точками в 3Д пространстве