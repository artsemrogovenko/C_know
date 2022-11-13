/* Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Printnumber(1,n));

string Printnumber(int start,int end){
    if(start==end) return start.ToString();
    return (start+" " + Printnumber(start+1,end));
} */

/* **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
 */
 Console.WriteLine("выведет все натуральные числа в промежутке от M до N.");
 Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);


if(n > m) {Console.WriteLine(Printnumber(m,n)); }
else {
    Console.WriteLine(Printnumber(n,m));
}

string Printnumber(int start,int end){
    if(start==end) return start.ToString();
    return (start+" " + Printnumber(start+1,end));
}
/* 
**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9
 Console.WriteLine();
 int num=new Random().Next(100, 999);
 Console.WriteLine(num);
  Console.WriteLine(SumNum(num));

int SumNum(int number) {
if(number==0) return 0;
return number=number%10 + SumNum(number/10);
}

**Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */
Console.WriteLine("возводит число А в целую степень B с помощью рекурсии");
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("В степень числа B");
int b = int.Parse(Console.ReadLine()!);
if (b==0){
    Console.WriteLine("1");
}
else Console.WriteLine(Print(a,b));


int Print(int num,int step){
    if(step==0) return 1;
    return (Print(num,step-1)*num);
}