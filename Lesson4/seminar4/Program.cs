// Cумма числео от 1 до A
//7 -->28
//4 -> 10

Console.Write("Суммда чисел от 1 до : ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSum(A)}");

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}
 
//**Задача 26:**
/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.Write("Подсчет количества цифр в числе : ");
string x = Console.ReadLine()!;

int GetNum(string counts){
int b = 0;
for (int i = 1; i <= x.Length; i++)
{
    b++;
}
return b;
}
Console.WriteLine($"Количество цифр чисел от 1 до {x} = {GetNum(x)}");

/* **Задача 28:**
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4  -> 24
5  -> 120 */
Console.Write("Выдаёт произведение чисел от 1 до : ");
int num = int.Parse(Console.ReadLine()!);
int GetResult(int limit)
{
    int sum = 1;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum * i;
    }
    return sum;
}
Console.WriteLine($"Результат {GetResult(num)}");

/*
**Задача 30:**
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
Console.WriteLine("Заполнение массива 0 или 1");
int[] mas = new int[8];
for (int i = 0; i <= 7; i++)
    {
        mas[i] = new Random().Next(2);
    }
Console.WriteLine(String.Join(",", mas));

int[] cycle(int size){
    int[] result=new int[size];
    for (int i = 0; i < size; i++)  {
        result[i] = new Random().Next(0,2);
    }
return result;
}
mas=cycle(8);
Console.WriteLine(String.Join(",", mas));
