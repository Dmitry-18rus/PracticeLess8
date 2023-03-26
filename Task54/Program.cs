// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);
SortNewArray(array);
PrintArray(array);

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

void SortNewArray (int [,] array)
{
    int temp;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k=j+1; k<array.GetLength(1); k++)
                    {
                        if (array[i,j] < array[i,k])
                        {
                            temp = array[i,k];
                            array[i,k] = array[i,j];
                            array[i,j]=temp;
                        }
                    }                   
                }            
            }
}
