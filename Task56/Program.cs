// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);
int [] newArray = new int [m];
SumArray(array);
PrintArrayNew(newArray);
FindMinArray(newArray);

void FillArray (int m, int n)
{
    for (int i = 0; i<array.GetLength(0);i++)
        for (int j = 0; j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(0,10);
}
void PrintArray (int [,] array)
{
    Console.WriteLine();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write($"{array[i,j],5} \t");
        Console.WriteLine();
    }
Console.WriteLine();
}

void SumArray (int [,] array)
{
    int sum=0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum=0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum = sum + array [i,j];
                    newArray[i] = sum;                  
                }            
            }
}

void PrintArrayNew (int [] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        Console.Write($"{array[i],5} \t");
    }
    Console.WriteLine();
}

void FindMinArray (int [] array)
{
    int minIndex = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]<min)
        {
            min = array [i];
            minIndex = i;
        }
        
    }
    Console.WriteLine($"{minIndex+1} строка");
}

