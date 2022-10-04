// Задача 10:
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if (number>99 && number<1000){

int num1 = number / 100;
int num3 = number % 10;
int num2 = number - ((num1 * 100) + num3);
num2 = num2 / 10;
Console.WriteLine($"Второе число {num2}");
}
else
    Console.WriteLine("Число не трехзначное");
