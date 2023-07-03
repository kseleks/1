// // Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// [3 4 5] yes
// [3 4 51] no


System.Console.Write("ВВЕДИТЕ ЧИСЛО соответствующее длине ПЕРВОЙ(1) СТОРОНЫ треугольника : ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ВВЕДИТЕ ЧИСЛО соответствующее длине ВТОРОЙ(2) СТОРОНЫ треугольника : ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("ВВЕДИТЕ ЧИСЛО соответствующее длине ТРЕТЬЕЙ(3) СТОРОНЫ треугольника : ");
int number3 = Convert.ToInt32(Console.ReadLine());



bool CheckPoint (int number1, int number2, int number3)
// булев метод проверки по теореме
{
if (number1<number2+number3 && number2<number1+number3 && number3<number1+number2)
    {
        return true;
    }
return false;
}


if (CheckPoint(number1,number2,number3))
// применяем метод конкретно к этой задаче
{
    System.Console.WriteLine("Может существовать");
    }
else
{
    System.Console.WriteLine("Может существовать");
}    


