//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.WriteLine("Программа поменяет местами первую и последнюю строку массива");
Console.WriteLine("Количество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов :");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] Array1 = new int[rows, columns];
Array1=FillArray(Array1);
PrintArray(Array1);
ReverceRows(Array1);
Console.WriteLine();
PrintArray(Array1);

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

void ReverceRows(int[,] arr){
    int temp;
    int i=0; // /
        for (int j = 0; j < arr.GetLength(1); j++)
        {
temp=arr[i,j];
arr[i,j]=arr[arr.GetLength(0)-1,j];
arr[arr.GetLength(0)-1,j]=temp;        
        }        
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.WriteLine("Программа заменяет строки на столбцы.");
int[,] Array3=new int[Array1.GetLength(0),Array1.GetLength(0)];
Array3=RotateArray(Array1);
Console.WriteLine();

int[,] RotateArray(int[,] original){
    int[,] temp=new int[original.GetLength(1),original.GetLength(0)];
if(original.GetLength(0) != original.GetLength(1)){
   Console.WriteLine("Замена невозможна");
}
else {
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            temp[j,i]=original[i, j] ;
        }
    }
    PrintArray(temp);
}
return temp;
}

//Задача 59: Отсортировать нечетные столбцы массива по возрастанию.
// Вывести массив изначальный и массив с отсортированными нечетными столбцами
Console.WriteLine("Программа отсортирует нечетные столбцы по возрастанию.");
PrintArray(Array1);
Console.WriteLine();
int[,] aarra=Sorting(Array1 );
PrintArray(aarra);

int[,] Sorting(int[,] original){
    int[,] sorted=original;
    int[] result=new int[original.GetLength(0)]; // размер от строк
for (int i = 0; i < original.GetLength(1); i++) //  cтолбец
    {
               
if (i % 2 == 1) { // если столбец нечетный
    for (int j = 0; j < original.GetLength(0); j++) { // иду по каждой строке
    result[j] = original[j, i];
    }
            int maxIndex = result.Length - 1;
            while (maxIndex != 0) // пока не дойду до первого индекса result
            {
                for (int index = 0; index < maxIndex; index++) // записываю в крайний индекс максимальное число
                {
                    if (result[maxIndex] <= result[index]) 
                    {
                        int num = result[maxIndex];
                        result[maxIndex] = result[index];
                        result[index] = num;
                    }
                }
                maxIndex--;
            }

            for (int j = 0; j < original.GetLength(0); j++){ // записываю по поряку в двумерный массив
                sorted[j, i] = result[j];
            }
        }
    }
return sorted;
}

