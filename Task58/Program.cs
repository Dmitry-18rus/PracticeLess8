// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Введите кол-во строк 1 матрицы");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов 1 матрицы");
// int n1 = Convert.ToInt32(Console.ReadLine());
int m1 =2;
// int n1 = 2;

// Console.WriteLine("Введите кол-во строк 2 матрицы");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кол-во столбцов 2 матрицы");
// int n2 = Convert.ToInt32(Console.ReadLine());
// int m2 = 2;
int n2 = 2;

int [,] array1 = new int [2,2] {{2,4},{3,2}};
int [,] array2 = new int [2,2] {{3,4},{3,3}};
// int [,] array1 = new int [m1,n1];
// int [,] array2 = new int [m2,n2];
// string a1 = "array1";
// string a2 = "array2";
// FillArray(m1, n1, array1,a1);
// FillArray(m2, n2, array2,a2);


PrintArray(array1);
PrintArray(array2);
int [,] arrayRes = new int [m1,n2];
ProizvedArray(array1,array2,arrayRes);
PrintArray(arrayRes);

// void FillArray (int m, int n,int [,] array, string a)
// {
//     for (int i = 0; i<array.GetLength(0);i++)
//         for (int j = 0; j<array.GetLength(1);j++)
//         {
//             // array[i,j]= new Random().Next(0,10);
//             Console.WriteLine($"Введите {i},{j} элемент матрицы {a}");
//             array[i,j]=Convert.ToInt32(Console.ReadLine());
//         }
// }

void PrintArray (int [,] array)
{
    Console.WriteLine();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
            Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
Console.WriteLine();
}

void ProizvedArray(int[,] array1, int[,] array2, int[,] arrayRes)
{
    for (int i1 = 0; i1 < array1.GetLength(0); i1++)
    {
        for (int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            for (int i2 = 0; i2 < array2.GetLength(0); i2++)
            {
            arrayRes[i1, j2] += (array1[i1, i2] * array2[i2, j2]);
            // Console.Write(arrayRes[i1, j2] + " ");
            }
        }
    }
}


