// Задача 18 /разобрана на семинаре/
// Написать программу, которая по заданному номеру четверти, 
// показывает диапозон возможных координат точек этой четверти X и Y

// четверть от 1 до 4







string [] text = {"x>0; y>o",
                   "x<0; y>0",
                   "x<0; y<0",
                   "x>0; y<0"};

 System.Console.WriteLine("Введите номер четверти координат плоскости-  ");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num >= 1 && num <=4)
 {
    System.Console.WriteLine(text[num-1]);
 }              
 else
 {
    System.Console.WriteLine("ВВеденная четверть не подходит по условию");
 }

