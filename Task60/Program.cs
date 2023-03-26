// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во 3го измерения ");
int z = Convert.ToInt32(Console.ReadLine());


int [,,] array = new int [m,n,z];
int [] newArray = new int [m*n*z];
FillArray(m, n, z);
PrintArray(array);

// SumArray(array);
// PrintArrayNew(newArray);
// FindMinArray(newArray);

void FillArray (int m, int n, int z)
{
    for (int i1 = 0; i1<newArray.Length; i1++)
    {
        int rand = new Random().Next(10, 100);
        var find = Array.Exists<int>(newArray, v=> v==rand);
        if (find == true)
        {
            i1--;
        }
        else
        {
            newArray[i1] = rand;
        }
    Console.Write (newArray[i1]+" ");
    }

    int i2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = newArray[i2];
                i2++;
            }
        }
    }
}


void PrintArray (int [,,] array)
{
    Console.WriteLine();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            for (int k=0; k< array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]},({i},{j},{k}) \t");
            Console.WriteLine();
        }
    }
Console.WriteLine();
}