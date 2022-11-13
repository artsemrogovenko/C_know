/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
 Console.WriteLine("натуральные числа в промежутке от N до 1.");
 Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine()!);

if (num>1)   Console.WriteLine(CountDown(num));
else { 
    Console.WriteLine("недопустимое значение");
}

int CountDown(int start){
    if(start==1){
        return 1;
        }
     Console.Write(start+", ");
    return CountDown(start-1);
}

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
 Console.WriteLine();
 Console.WriteLine("Cумма чисел в промежутке от M до N.");
 Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

if(n > m) {Console.WriteLine(SumNumber(m,n)); }
else {
    Console.WriteLine(SumNumber(n,m));
}

int SumNumber(int start,int end){
    if(start==end) return end;
    return (start+=SumNumber(start+1,end));
}
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */
 Console.WriteLine();
 Console.WriteLine("функция Аккермана с помощью рекурсии");
  Console.WriteLine("ввести неотрицательное число");
 Console.WriteLine("Введите число M");
int first = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите число N");
int second = int.Parse(Console.ReadLine()!);

if (first >= 0 && second >= 0){
    Console.WriteLine("A(m,n)"+Akkerman(first,second));
}
else  
Console.WriteLine("неподходящие значения");

long Akkerman(long a, long b){
    if (a == 0) return b + 1;
        else
    if ((a != 0) && (b == 0)) return Akkerman(a - 1, 1);
        else
return Akkerman(a-1,Akkerman(a,b-1));
}
