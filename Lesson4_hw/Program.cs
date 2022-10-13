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
}

