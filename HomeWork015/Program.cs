// Написать программу принимающую на входе цифру обозначающую день недели и проверяет:
// является ли этот день выходным

bool WorkDay(int number)
{
     if (number > 0 || number < 6)
     {
        return true;
     }
     else
     {
        return false;
     }

}   

System.Console.WriteLine($"ВВОДИМ СЛУЧАЙНЫМ ОБРАЗОМ ЧИСЛО ОТ 1 ДО 7");
int numb = Convert.ToInt32 (Console.ReadLine());


if (numb > 7)
{
   System.Console.WriteLine ("Не подходит по условию задачи");
}

else if (WorkDay(numb))
   {
    System.Console.WriteLine ($"It is {numb} work day");
   }
   else
   {
    System.Console.WriteLine ($"{numb} day of week. You are wellcome! It's weekend!");
   }



