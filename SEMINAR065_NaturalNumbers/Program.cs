// // Задайте значения M и N
// Напишите программу, которая выводит все натуральные числа в промежутке от M до N

// M=1
// N=5
// ---> 1,2,3,4,5

// M=4
// N=8
// ---> 4,6,7,8


int M=1;
int N=3;

void NaturalNumbers(int N,int M)
{
    if(N==M)
    {
        System.Console.WriteLine($"{N}");
        return;
    }
   NaturalNumbers(M,N-1);
   System.Console.WriteLine($"{N}");
}
NaturalNumbers(M,N);
