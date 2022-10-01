// See https://aka.ms/new-console-template for more information
// Ctrl + /
// Напишите программу которая на вход принимает два числа и проверяет,является ли первое число квадратом второго
Console.WriteLine("Введите пераое число ");
int num1 = int.Parse(Console.ReadLine()!); //int.Parse -конвертируется число в тип Int
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine()!);


if (Math.Pow(num2, 2) == num1){ //Квадратный корень
    Console.WriteLine($"{num1}Первое число равно квадратом второго{num2}");
}
else
    Console.WriteLine("Первое число не является квадратом второго");
