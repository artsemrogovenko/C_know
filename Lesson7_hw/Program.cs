/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.WriteLine("Массив с вещественными числами");
Console.WriteLine("Количество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов :");
int columns = int.Parse(Console.ReadLine()!);
double[,] Array1 = new double[rows, columns];
Console.WriteLine();
Array1 = doublefill(Array1);
PrintArray(Array1);

double[,] doublefill(double[,] array)
{
    double[,] temp = new double[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[i, j] = new Random().Next(-10, 10);


            if (temp[i, j] % 100 <= 9 && temp[i, j] % 100 > 0)  // добавляю десятую часть для красоты
            {
                double a = temp[i, j] % 100;
                temp[i, j] = temp[i, j] + (a / 10);
            }
        }
    }
    return temp;
}



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 10 <= 0)  // если после зяпятой ноль, убираю запятую
            {
                Console.Write($"{(int)array[i, j]}  ");
            }
            else if (array[i, j] % 10 > 0)
                Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */
Console.WriteLine("Проверка позиции и вывод значения");
Console.WriteLine("Позиция строки отсчет с 0");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Позиция столбца отсчет с 0");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(CheckIndex(Array1, a, b));

string CheckIndex(double[,] array, int posRow, int posCol)
{
    string s = "Такого элемента в массиве нет";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == posRow)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == posCol && i == posRow)
                {
                    s = "Элемент -> " + array[i, j];
                }
            }
        }
    }
    return s;
}


/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.WriteLine("Среднее арифметическое каждого столбца");
int[,] IntArray = new int[3, 6];
IntArray = FillArray(IntArray);
DualPrint(IntArray);
AverageNum(IntArray);

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
    return arr;
}

void AverageNum(int[,] array)
{
    int col = array.GetLength(1);
    double[] result = new double[array.GetLength(1)]; // сколько столбцов столько и ячеек

    Console.WriteLine();
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            result[columns] += array[rows, columns];
        }
        result[columns] = result[columns] / array.GetLength(0); // значение делю количество на строк
    }
    // вывожу результат каждого столбца
    Console.WriteLine("Результат");
    for (int i = 0; i < result.Length; i++)
    {
        if ((result[i] * 10) % 10 == 0)    {// отбрасываю запятую если после стоит ноль
            Console.Write($"{result[i]}");
        }
        else {
            Console.Write($"{result[i]:F1}");
        }
         if (i<result.Length-1){Console.Write(" ; "); }
    }
    Console.WriteLine();
}


void DualPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

/* Данные задачи идут как доп. на это ДЗ, но являются обязательными на 8, поэтому у вас есть много времени их решить
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
int[] TwoDigit=new int[90];
IncrementFill(TwoDigit); 
 Console.WriteLine("Задан диапазон двузначных чисел");

void IncrementFill(int[] array){
    for (int val = 10, i = 0; i < array.Length; val++, i++)
    {
        array[i] = val;
    }
}

int[, ,] TripleArray=new int[2,2,2];
TripleFill(TripleArray,TwoDigit);
PrintTriple(TripleArray);

bool Reiteration (int[] array, int value) {
    bool result=false;
for (int i = 0; i < array.Length ; i++ )
    {
        if(array[i]==value){
            result=true;
            break;
        }
    }
    return result;
}

void TripleFill(int[, ,] array, int[] numbers){
int tempindex = 0;
int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

    while (tempindex < temp.Length)
    {
        int random = numbers[new Random().Next(0, numbers.Length)];
        if (! Reiteration(temp, random))
        {
            temp[tempindex] = random;
            tempindex++;
        }
    }

    tempindex = 0;

 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[tempindex];
                tempindex++;
            }
        }
    }
}

void PrintTriple(int[, ,] array)
{
    int i=0;
    int j=0;
    int k=0;
    while (k < array.GetLength(2))
    {
         Console.WriteLine($"вывод {k+1} слоя трехмерного массива");
        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        k++;
    }
    }


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] Fillclockwise(int[,] array)
{
    int[,] temp = new int[array.GetLength(0), array.GetLength(1)];
    int row = array.GetLength(0) - 1;
    int col = array.GetLength(1) - 1;
    int steps = array.GetLength(1) * array.GetLength(0); // максимальное число
    int i = 0;
    int j = 0;
    int number = 1; // начальное число
    int depth = 0; // для перехода на шаг внутрь
    while (number < steps)
    {
        while (j < col - depth && number <= steps)
        {
            temp[i, j] = number;
            j++;
            number++;
        }

        while (i < row - depth && number <= steps)
        {
            temp[i, j] = number;
            i++;
            number++;
        }

        while (j > depth && number <= steps)
        {
            temp[i, j] = number;
            j--;
            number++;
        }

        while (i > depth && number <= steps)
        {
            temp[i, j] = number;
            i--;
            number++;
        }

        depth++;
        i++;
        j++;
     //    Console.WriteLine($"i={i} j={j} number={number}");
    }
        if (steps % 2 > 0) //если массив из нечетных количеств строк и столбцов поставить в центр максимальное число
        { 
           temp[array.GetLength(0) / 2, array.GetLength(1) / 2] = steps;
        }
    return temp;
}

void PrintDual(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:D2}", array[i, j]));
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("заполнение по спирали");
int[,] array2 = new int[3,3];
array2 = Fillclockwise(array2);
PrintDual(array2);