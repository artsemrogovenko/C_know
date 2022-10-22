Console.WriteLine("Двумерный массив с числами от 0 до 10");
Console.WriteLine("Строк");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Столбцов");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] arr = GetArray1(rows1, columns1, 0, 10);
PrintArray(arr);

int[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
 A = m+n. Выведите полученный массив на экран.
 */
Console.WriteLine("Красивый двумерный массив");
Console.WriteLine("Ввести стоки и столбцы");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

/* void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
    } */

/* Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. */
int[,] array2 = array;
void EvenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
}
Console.WriteLine("у которых оба индекса чётные, и замена этих элементов на их квадраты");
EvenArray(array2);
PrintArray(array2);

/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
 */

Console.WriteLine("сумма элементов по диагонали (с индексами (0,0); (1;1) и т.д");
int SumDiagonal(int[,] array)
{ // сверху слева вниз вправо
    int result = 0;
    for (int i = 0, j = 0; i < array.GetLength(0); i++, j++)
    {
        result += array[i, j];
    }
    return result;
}
Console.WriteLine(SumDiagonal(array));