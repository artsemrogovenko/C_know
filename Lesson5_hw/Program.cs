/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] mas = ArrRandom(6, 100, 999);
Console.WriteLine(String.Join(",", mas));
Console.WriteLine($"Четых чисел: {EvenNumber(mas)}");

int EvenNumber(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0 */

int[] mas2 = ArrRandom(6, 0, 100);
Console.WriteLine(String.Join(",", mas2));
Console.WriteLine($"Cумма нечетных позиций в массиве: {SumElem(mas2)}");

int SumElem(int[] array){
int sum = 0;
for (int i=1; i < array.Length; i++)
{
        sum=sum+array[i];
        i++;
}
return sum;
}

/* Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, 
с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
int[] mas3 =RandInt(4);
Console.WriteLine(String.Join(",", mas3));
Console.WriteLine($"Разница между макс. и мин. числом = {CompareElem(mas3)}");

int[] RandInt(int size){
    int[] mas = new int[size];
    mas[0] = new Random().Next(-69623478,696234780);
    for (int i = 1; i < size; i++)
    {
        mas[i] = new Random().Next()-mas[i-1];
    }
    return mas;
}

int CompareElem(int[] arr)
{
    int value =0;
    int min = arr[0];
    int max = arr[0];
        foreach (int element in arr)
        {
            if (element > min && element > max)
            {
                max=element;
            }
        }
        foreach (int element2 in arr)
        {
            if (element2 < min && element2 < max)
            {
                min=element2;
            }
        }  
        Console.WriteLine($"мин={min} макс={max}");
        value=max-min;
    if(value < 0){
        value=value/-1;
    }    
    return value;
}
//-----------------------------------//


int[] ArrRandom(int elements, int MinVal, int MaxVal)
{
    int[] mas = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        mas[i] = new Random().Next(MinVal, MaxVal + 1);
    }
    //Console.WriteLine(String.Join(",", mas));
    return mas;
}