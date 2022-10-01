/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7  
a = 2 b = 10 -> max = 10  
a = -9 b = -3 -> max = -3  
 */
Console.WriteLine("Введите два числа ");
int a= int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if(a>b)
Console.WriteLine($"Max={a}\tMin={b}");
else
Console.WriteLine($"Max={b}\tMin={a}");
/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7  
44 5 78 -> 78  
22 3 9 -> 22  */ 
Console.WriteLine("Введите три числа ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if(a>b & a>c){   Console.WriteLine($"Max={a}");}
if(b>a & b>c){   Console.WriteLine($"Max={b}");}
else
Console.WriteLine($"Max={c}");
/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да  
-3 -> нет  
7 -> нет  
 */
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if(a%2==0){
    Console.WriteLine($"Число {a} четное");}
else 
Console.WriteLine($"Число {a} нечетное");
/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4  
8 -> 2, 4, 6, 8   */
Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine()!);
int i = 1;
if(a>0){
while (i < a)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
}
//Тут есть возможность для отрицательных чисел не включая 0
if(a<0){
while (i > a)
{
    if (i % 2 == 0 & i!=0)
    {
        Console.WriteLine(i);
    }
    i--;
}
}