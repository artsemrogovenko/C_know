// Задача 10:
/*
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if (number > 99 && number < 1000)
{

    int num1 = number / 100;
    int num3 = number % 10;
    int num2 = number - ((num1 * 100) + num3);
    num2 = num2 / 10;
    Console.WriteLine($"Второе число {num2}");
}
else
    Console.WriteLine("Число не трехзначное");
*/
//задача 13
Console.WriteLine("Программа выводит третью цифру заданного числа");
Console.WriteLine("Введите число");
//int number = (int)Math.Pow(1000,3);
int number = int.Parse(Console.ReadLine()!);
if (number > 99 || number < -99){
    while (number > 999 || number < -999)    {
        number = number / 10;
        Console.WriteLine(number);
    }
    if (number > 99 && number < 1000 || number < -99 && number > -1000)
    {
        int num3 = number % 10;
        Console.WriteLine($"Третья цифра {num3}");
    }
}
else
    Console.WriteLine("третьей цифры нет");
