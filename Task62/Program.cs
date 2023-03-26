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
    int sum = 0;
    for (int i = 0; i<array.GetLength(0);i++)
        for (int j = 0; j<array.GetLength(1);j++)
        {
            if (i==0)
            {
                sum = sum+1; 
                array[i,j] = sum;
            break;
            }
            while (j==(array.GetLength(1)-1))
            {
                array[i,j]= sum; 
                sum = array[i,j]+1;
                
            break;
            }
            while (i==array.GetLength(0)-1)
            {
                // sum=7
                sum = sum-j;
                array[i,j]=sum+n-1;
            break;
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

