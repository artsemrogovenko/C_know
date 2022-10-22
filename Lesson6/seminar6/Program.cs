int[] arr1 = ArrRandom(5, 0, 10);
Console.WriteLine(String.Join(",", arr1));
int[] result = ReverceArray(arr1);
Console.WriteLine(String.Join(",", result));

int[] ReverceArray(int[] array)
{
    int[] temp = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        temp[i] = array[array.Length - i - 1];
    }
    return temp;
}

int[] ArrRandom(int elements, int MinVal, int MaxVal)
{
    int[] mas = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        mas[i] = new Random().Next(MinVal, MaxVal + 1);
    }
    return mas;
}

/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины. */
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("Треугольник со сторонами 23, 12, 6");
int[] Triangle = { 23, 12, 6 };
Console.WriteLine(GetTriangle(Triangle));
Console.WriteLine("Треугольник со сторонами 5, 5, 5");
int[] Triangle2 = { 5, 5, 5 };
Console.WriteLine(GetTriangle(Triangle2));

string GetTriangle(int[] arr)
{
    string result = "";
    if (arr[0] + arr[1] > arr[2] &&
        arr[1] + arr[2] > arr[0] &&
        arr[2] + arr[0] > arr[1])
    {
        result = "Треуголник существует";
    }
    else result = "не существует"; 
    return result;
}

/* **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */
Console.WriteLine("Программа преобразует это число в двоичную сиситему:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", ReverceArray(ConvertNumber(a, 2, 8))));
Console.WriteLine();

int[] ConvertNumber(int number, int system, int bitSize)
{
    int temp = number;
    int[] Result = new int[bitSize];
    while (temp / system >= 1)
    {
        for (int i = 0; i < bitSize; i++)
        {
            Result[i] = temp % system;
            temp = temp / system;
        }
    }
    return Result;
}

//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] mas1 = { 646464, 2121212, 78787, 90900, 454545 };
Console.WriteLine("mas1 = " + String.Join(",", mas1));
int[] mas2 = new int[5];
Console.WriteLine("mas2 = " + String.Join(",", mas2));
mas2 = CopyArray(mas1);
Console.WriteLine("mas2 = " + String.Join(",", mas2));


int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}