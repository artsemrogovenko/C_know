/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
**Например:**
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.WriteLine("Введите число ");
int num1 = int.Parse(Console.ReadLine()!);
int result = num1 * num1;
Console.WriteLine("Результат "+ result);
/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 ->  Пятница
*/
Console.WriteLine("Введите день недели (1,2,3) ");
int day = int.Parse(Console.ReadLine()!);

if(day==1){    Console.WriteLine("Понедельник");}
if(day==2){    Console.WriteLine("Вторник");}
if(day==3){    Console.WriteLine("Среда");}
if(day==4){    Console.WriteLine("Четверг");}
if(day==5){    Console.WriteLine("Пятница");}
if(day==6){    Console.WriteLine("Суббота");}
if(day==7){    Console.WriteLine("Воскресенье");}
if(day<1 || day>7){    Console.WriteLine("нет такого дня");}