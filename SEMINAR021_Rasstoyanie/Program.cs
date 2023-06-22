// Задача №21 разобрана на семинаре
// Напишите программу, которая принимает на вход координаты точек
// и находит РАССТОЯНИЕ между ними в 2Д пространстве

// А(3,6)
// В(2,1)------>5.09---5,1

// A(7,-5)
// B(1,-1)------>7.21

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

double Distance2D (double Ax, double Ay, double Bx, double By)
{
double distance=Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2));
return Math.Round(distance, 2);
}

System.Console.Write("ВВЕДИТЕ координаты Х точки А: ");
double Ax=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Y точки А: ");
double Ay=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты X точки B: ");
double Bx=Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Y точки B: ");
double By=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Расстояние  между точками А и В= {Distance2D (Ax,Ay,Bx,By)} ");


