// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Ввести 5 чисел, подсчет количества больше 0 ");
int[] M = new int[5];
M = FillArray(M);
Console.WriteLine(String.Join(",", M));
Console.WriteLine($"Количество {GetCount(M)}");

int[] FillArray(int[] Array)
{
    int[] M = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        M[i] = int.Parse(Console.ReadLine()!);
    }
    return M;
}

int GetCount(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element > 0) count++;
    }
    return count;
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. 
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("Нахождение точки пересечения двух прямых");
int[] Lines = new int[4]; // 4 значения на ввод
GetLines(Lines); // заполняю массив значениями
Console.WriteLine("Точка пересечения");
Console.WriteLine(GetPoint(Lines));

string GetPoint(int[] arr) // double b1, double k1, double b2, double k2
{
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];
    double result1 = (b2 - b1) / (k1 - k2);
    double result2 = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return $"{result1}" + " ; " + $"{result2}";
}

void GetLines(int[] arr)
{
    Console.WriteLine("значения первой линии");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 2) { Console.WriteLine("значения второй линии"); }
        arr[i] = int.Parse(Console.ReadLine()!);
    }
}
/* Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)
Найти произведение всех элементов массива целых чисел, меньших заданного числа.
Размерность массива 10. Заполнение массива осуществить случайными числами от 50 до 100.
 */
Console.WriteLine($"Произведение элементов меньших заданного");
int[] Array2 = new int[10];
Array2 = ArrRandom(10, 50, 100);
Console.WriteLine(String.Join(",", Array2));
Console.WriteLine("Введите число в этом диапазоне");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение {Multiply(Array2, num)}");


int Multiply(int[] Array, int number)
{
    int countelements = 0;
    int result = 0;

    foreach (int element in Array)
    {
        if (element < number) countelements++; // узнаю количество цифр меньше введенного, для указания размера массива
    }

    if (countelements >= 2)
    {
        int[] temp = new int[countelements];
        for (int i = 0, k = 0; i < Array.Length; i++)
        {
            if (Array[i] < number)
            {
                temp[k] = Array[i]; // узнаю количество цифр меньше введенного    
                k++;
            }
        }
        result = temp[0];
        Console.WriteLine(String.Join(",", temp));
        for (int i = 1; i < temp.Length; i++)
        {
            result = result * temp[i];
        }

        return result;
    }
    else return 0;

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
