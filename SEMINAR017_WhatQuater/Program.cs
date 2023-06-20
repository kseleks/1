// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


void PrintQuater (int x, int y)
{
if (x > 0 && y > 0)
{
    System.Console.WriteLine (" Точка располагается в ПЕРВОЙ ЧЕТВЕРТИ");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine (" Точка располагается во ВТОРОЙ ЧЕТВЕРТИ");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine (" Точка располагается в ТРЕТЬЕЙ ЧЕТВЕРТИ");
}
else if (x > 0 && y < 0)
{
   System.Console.WriteLine (" Точка располагается в ЧЕТВЕРТОЙ ЧЕТВЕРТИ"); 
}
else 
{
    System.Console.WriteLine ("Точка попала на систему координат, чего не может быть по условию задачи"); 
}
}

System.Console.Write("ВВЕДИТЕ координаты Х-  ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("ВВЕДИТЕ координаты Y-  ");
int y = Convert.ToInt32(Console.ReadLine());


PrintQuater(x,y);

