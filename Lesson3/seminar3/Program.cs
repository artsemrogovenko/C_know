/*
Console.WriteLine("ВВедите четверть");
int number = int.Parse(Console.WriteLine());

switch (number)
{
    case 1:
        Console.WriteLine("x>0,y>0");
        break;
    case 2:
        Console.WriteLine("x<0,y>0");
        break;
    case 3:
        Console.WriteLine("x<0,y<0");
        break;
    case 4:
        Console.WriteLine("x>0,y<0");
        break;
    default:
        Console.WriteLine("нет такой четверти");
        break;
}
*/
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */
/*
Console.WriteLine("Расстояние между точками");
int xa = 3;
int ya = 6;
int xb = 2;
int yb = 1;

double result = Math.Sqrt( Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
Console.WriteLine($"Результат {result}");
*/
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*
Console.Write("Квадраты чисел от 1 до числа: ");
int number = int.Parse(Console.ReadLine());
for(int i=1; i<=number; i++){
  //  int res= Convert.ToInt32 (Math.Pow(i,2));
Console.Write(Math.Pow(i,2)+", ");
//Console.WriteLine(res);
}
*/

/*
Определить, является ли заданное шестизначное число счастливым.
 (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).
*/

Console.Write("шестизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 99999 && number <= 999999)
{
    if ((number / 100000)
 +  ((number / 10000) % 10)
 +  ((number / 1000) % 10)
 == ((number % 1000) / 100)
 +  ((number % 1000) / 10 % 10)
 +  ((number % 1000) % 10))
    {
        Console.Write("Cчастливое число ");
    }
    else
    {
        Console.Write("Обычное число ");
    }
}
else
    Console.Write("Не шестизначное число ");

Console.Write("ВВести шестизначное число ");
String x = Console.ReadLine()!;
if (x.Length == 6)
{
    int a = Convert.ToInt32(x[0] + x[1] + x[2]);
    int b = Convert.ToInt32(x[3] + x[4] + x[5]);
    if (a == b)
    {
        Console.WriteLine("You Win");
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
else
    Console.WriteLine("Не шестизначное число");