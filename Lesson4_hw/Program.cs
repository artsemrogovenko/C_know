/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16 */

Console.WriteLine("Число А в натуральную степень B");
Console.Write("Число ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("в степень ");
int B = int.Parse(Console.ReadLine()!);
Multiply(A, B);

void Multiply(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    Console.WriteLine($"Произведение числа {A} в степени {B} = {result}");
    return;
}

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11 82 -> 10
9012 -> 12 */
Console.WriteLine("Программа вычислит сумму цифр в числе:");
string number = Console.ReadLine()!;
Console.WriteLine($"Сумма равна {GetSumm(number)}");

int GetSumm(string x)
{
    int sum = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] > 47 && x[i] < 58)
        { // если встретится буква , то суммироваться небудет
            sum = sum + x[i] - 48; //  ASCII таблица цифра 0 = 48 цифра 9=57
        }
    }
    return sum;
}

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Заполнение массива");
Console.Write("Задать размер массива ");
int razmer = int.Parse(Console.ReadLine()!);

Console.Write("Задать минимальное число ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Задать максимальное число ");
int max = int.Parse(Console.ReadLine()!);

ArrRandom(razmer,min,max);

void ArrRandom(int elements, int MinVal, int MaxVal)
{
    int[] mas = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        mas[i] = new Random().Next(MinVal, MaxVal);
    }
    Console.WriteLine(String.Join(",", mas));
}