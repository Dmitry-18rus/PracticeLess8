// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

int [,] array = new int [m,n];
FillArray(m, n);
PrintArray(array);


void FillArray (int m, int n)
{
    int sum = 1;
    int i = 0; 
    int j = 0;
    while (sum <=m*n)
    {
    array[i,j] = sum;
        {
            if (i <= j + 1 && i + j < n - 1)
                j++;
            else if (i < j && i + j >= n - 1)
                i++;
            else if (i >= j && i + j > n - 1)
                j--;
            else
                i--;
            sum++;
        }
    }
}

void PrintArray (int [,] array)
{
    Console.WriteLine();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write(string.Format("{0:d2}",array[i,j])+"  ");
        Console.WriteLine();
    }
Console.WriteLine();
}

