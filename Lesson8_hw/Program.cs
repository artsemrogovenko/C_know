/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.WriteLine("Задан двумерный массив");
int[,] SampleArray = new int[4,6];
FillNoRepeat(SampleArray);
Print(SampleArray);
Console.WriteLine("Упорядочивание двумерного массива по убыванию в строке");
Print(SortArray(SampleArray));

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write( array[i, j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] original)
{
    int[,] sorted=original;
    int[] buffer=new int[original.GetLength(1)]; // размер от столбцов
    for (int i = 0; i < original.GetLength(0); i++) // строка
    {
        for (int j = 0; j < original.GetLength(1); j++)  // столбец
        {
            buffer[j]=original[i,j];
        }
        buffer=SortToLow(buffer);
        for (int j = 0; j < original.GetLength(1); j++)  // столбец
        {
            sorted[i,j]=buffer[j];
        }
    }
    return sorted;
}

int[] SortToLow(int[] array)
{
    int Position = 0;
    while (Position != array.Length - 1) // пока не дойду до крайнего правого
    {
        for (int index = array.Length - 1; index > Position; index--) // записываю в текущий левый максималььное 
        {
            if (array[Position] <= array[index]) // исключая предыдущее максимальное
            {
                int num = array[Position];
                array[Position] = array[index];
                array[index] = num;
            }
        }
        Position++;
    }
    return array;
}

void FillNoRepeat(int[,] array){

int tempindex = 0;
int[] temp = new int[array.GetLength(0) * array.GetLength(1)];
 
 while (tempindex < temp.Length) // создаю неповторяющиеся числа
    {
        int random = new Random().Next(0,temp.Length+1);
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
            {
                
                array[i, j] = temp[tempindex];
                tempindex++;
            }
        }
    }
  
}


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.WriteLine("Программа находит строку с наименьшей суммой элементов");
int[,] Array2=new int[4,3];
FillNoRepeat(Array2);
Print(Array2);
FindMinimalSum(Array2);

void FindMinimalSum (int[,] array){
    int[] result=new int[array.GetLength(0)]; // для сумм строк
    for (int i = 0; i < array.GetLength(0); i++) // строка
    {
        for (int j = 0; j < array.GetLength(1); j++)  // столбец
        {
            result[i]+=array[i,j]; // суммирую в индекс значения строки
        }        
    }
    
    int Position = 0;
    int minimal=result[0];
            for (int index = 0; index < result.Length; index++) 
        {
            if(result[index]<minimal){
        minimal=result[index];
        Position=index;
            }
        }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {Position+1} строка"); // 
}

/* Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
Console.WriteLine("произведение двух матриц.");
int[,] matrix1=new int[2,2];
int[,] matrix2=new int[2,2];
FillNoRepeat(matrix1);
FillNoRepeat(matrix2);
PrintMatrix(matrix1,matrix2);
int[,] multiplied=Multiply(matrix1,matrix2);
Print(multiplied);

void PrintMatrix(int[,] first,int[,] second){
    for (int i = 0; i < first.GetLength(0); i++) // строка
    {
        for (int j = 0; j < first.GetLength(1); j++)  // столбец
        {
Console.Write(first[i,j] + " ");
        }
        Console.Write("| ");
        for (int j = 0; j < first.GetLength(1); j++)  // столбец
        {
Console.Write(second[i,j] + " ");
        }
Console.WriteLine();
    }
}

int[,] Multiply(int[,] first,int[,] second){ // для квадратных массивов
    int[,] result = new int[first.GetLength(0), first.GetLength(1)];
    for (int i = 0; i < first.GetLength(0); i++) // строка
    {
        for (int j = 0; j < first.GetLength(1); j++)  // столбец
        {
            for (int k = 0; k < second.GetLength(0); k++)
            { // проход по столбцам второй матрицы
                result[i, j] += first[i, j] * second[k, j];
            }
        }
    }
    return result;
}

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[] TwoDigit=new int[90];
IncrementFill(TwoDigit); 
 Console.WriteLine("Задан диапазон двузначных чисел");
PrintArray(TwoDigit);

void IncrementFill(int[] array){
    for (int val = 10, i = 0; i < array.Length; val++, i++)
    {
        array[i] = val;
    }
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++)
    {        
              Console.Write(array[i]+" ");
    }
    Console.WriteLine();
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
10 09 08 07
*/

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

void PrintFormatted(int[,] array)
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
int[,] array2 = new int[4,4];
array2 = Fillclockwise(array2);
PrintFormatted(array2);
