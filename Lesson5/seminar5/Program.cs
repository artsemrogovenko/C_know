/* **Задача 32:** Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */
Console.WriteLine("Заполнение массива");
Console.Write("Задать размер массива ");
int razmer = int.Parse(Console.ReadLine()!);
Console.Write("Задать минимальное число ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Задать максимальное число ");
int max = int.Parse(Console.ReadLine()!);

int[] Array = ArrRandom(razmer, min, max);
Console.WriteLine(String.Join(",", Array));
Console.WriteLine("Инверсия массива ");
Console.WriteLine(String.Join(",", ArrReverce(Array)));

int[] ArrRandom(int elements, int MinVal, int MaxVal)
{
    int[] mas = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        mas[i] = new Random().Next(MinVal, MaxVal+1);
    }
    return mas;
}

int[] ArrReverce(int[] array)
{
    int[] value = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        value[i] = array[i] * -1;
    }
    return value;
}
/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

Console.WriteLine("Проверка присутсвия числа 3 в массиве: ");
Console.WriteLine(CheckNumber(Array, 3));


string CheckNumber(int[] array, int num){
    string result = "Отсутствует";
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        {
            result = "Присутствует";
            break;
        }       
    }
     return result;
} 


/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99]. */

int[] Mas2 = ArrRandom(123, 0, 500);
Console.WriteLine("Массив из 123 случайных чисел");
Console.WriteLine(String.Join(",",Mas2));
int CountsElemets(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"количество чисел от 10 до 99 = {CountsElemets(Mas2)}");
/* **Задача 37:**Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21
 */
Console.WriteLine("Произведение пар чисел в одномерном массиве");
int[] massiv = ArrRandom(5,1,12);
Console.WriteLine(String.Join(",", massiv));
Console.WriteLine("Результат");
Console.WriteLine(String.Join(",", MultiPair(massiv)));

int[] MultiPair (int[] mass){
    int size = mass.Length/2;
    if (mass.Length%2==1) {size++; }
    int[] multi=new int[size];
for (int i = 0; i < mass.Length/2; i++){
     multi[i] = mass[i] * mass[mass.Length-1-i];              
}
if( mass.Length%2==1){
    multi[size-1]=mass[mass.Length/2];
}
return multi;
}
