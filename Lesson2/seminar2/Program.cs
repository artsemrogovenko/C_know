
int number = new Random().Next(10,100);
Console.WriteLine(number);
int num1=number/10;
int num2=number%10;
int max=num1;
if (max<num2){
max=num2;
}
Console.WriteLine($"Максимальная цифра числа {number} = {max}"); */
/* 
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

*/
 Console.WriteLine("Hello, World!");
int number = new Random().
Next(100, 1000);
Console.WriteLine(number);
int num1 = number / 100;
int num3 = number % 10;
int num2 = number - ((num1 * 100) + num3);
num2 = num2 / 10;
Console.WriteLine($"Убрана число {num2}");
Console.WriteLine($"Максимальная цифра числа {number} = {max}"); */
/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4  -> кратно */

 Console.Write("ВВедите число 1:  ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите число 2:  ");
int b = int.Parse(Console.ReadLine()!);
if (b % a == 0){
    Console.WriteLine($"второе  кратно первому");
}
else{
    Console.WriteLine($"второе  некратно первому остаток {b/a}");
} 

/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14  ->  нет
46  ->  нет
161 ->  да
 */
 
Console.Write("ВВедите число :  ");
int с = int.Parse(Console.ReadLine()!);
if (с % 7 == 0 && с % 23 == 0)
{
    Console.WriteLine("Кратно 7 и 23");
}
else{
    Console.WriteLine("Число не кратно 7 и 23");
}

//  Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine( "является ли одно число квадратом другого");
Console.Write("ВВедите число 1:  ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите число 2:  ");
int b = int.Parse(Console.ReadLine()!);
if (a == Math.Pow(b, 2)) {
    Console.WriteLine($"{a} квадрат числа {b} ");
}
else if (b == Math.Pow(a, 2)) {
    Console.WriteLine($"{b} квадрат числа {a}");
}
else
 Console.WriteLine("Числа не соответствуют");