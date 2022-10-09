//Задача 19
Console.WriteLine("Является ли палиндромом");
Console.Write("Пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 9999 && number <= 99999)
{
    if ((number / 10000) ==(number % 10) &&
  ((number / 1000) % 10)==((number % 100) / 10)) {
        Console.WriteLine("Палиндром");
    }
    else {
        Console.WriteLine("Обычное");
    }
}
else { Console.WriteLine("Не пятизначное число "); }
    

Console.WriteLine("Второй вариант");
Console.Write("Вести пятизначное число ");
String x = Console.ReadLine()!;
if (x.Length == 5)
{
    if(x[0] == x[4] && x[1] == x[3]) {
        Console.WriteLine("Число палиндром");
    }
    else { Console.WriteLine("Не палиндром"); }
    
}
else { Console.WriteLine("Не пятизначное число"); }
